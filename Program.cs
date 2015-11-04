using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStarcraft05
{
	class Program
	{
		static int unitCode = 101;

		static void Main(string[] args)
		{
			List<TerranUnit> terranUnitList = new List<TerranUnit>();

			Barracks barracks = new Barracks(5, 150);
			Console.WriteLine("프로퍼티 Name: {0}", barracks.Name);

			Marine marine1 = barracks.CreateTerranUnit(1, unitCode++) as Marine;
			terranUnitList.Add(marine1);
			Marine marine2 = barracks.CreateTerranUnit(1, unitCode++) as Marine;
			terranUnitList.Add(marine2);

			Firebat firebat1 = barracks.CreateTerranUnit(2, unitCode++) as Firebat;
			terranUnitList.Add(firebat1);

			Bunker bunker = new Bunker(3, 100);
			//Console.WriteLine("프로퍼티 Name: {0}", bunker.Name);
			Console.WriteLine("프로퍼티 Name: {0}", ((Building)bunker).Name);

			bunker.PutUnit(marine1);
			bunker.PutUnit(marine2);
			bunker.PutUnit(firebat1);
			bunker.PutUnit(marine1);
			bunker.TakeOutAllUnits();

			// 총공격
			Console.WriteLine("+++++ 총 공격 개시 +++++");
			foreach (TerranUnit unit in terranUnitList)
			{
				unit.Attack();
			}
			// 인공지능 적을 만듭시다.
		}
	}
}
