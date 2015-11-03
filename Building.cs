using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStarcraft05
{
	abstract class Building
	{
		protected string name;
		public string Name { get { return name; } }

		protected int size;
		public int Size { get { return size; } }

		public int Strength { get; set; }
	}

	class Barracks : Building
	{
		public Barracks(int size, int strength)
		{
			base.name = "Barracks";
			base.size = size;
			base.Strength = strength;
			Console.WriteLine("{0} : 생성되었습니다.", Name);
		}

		// 마린과 파이어뱃 생성 부분 분리하고 외부에서 형변환 필요없도록 수정
		public TerranUnit CreateTerranUnit(int unitType, int unitCode)
		{
			switch (unitType)
			{
				case 1:
					Marine marine = new Marine(unitCode, 10);
					return marine;
				case 2:
					Firebat firebat = new Firebat(unitCode, 10);
					return firebat;
				default:
					return null;
			}
		}

		public void TakeOff() {}
		public void Land() {}
	}

	class Bunker : Building
	{
		const int CAPACITY = 4;
		private List<TerranUnit> unitList = new List<TerranUnit>(CAPACITY);

		public Bunker(int size, int strength)
		{
			base.name = "Bunker";
			base.size = size;
			base.Strength = strength;
			Console.WriteLine("{0} : 생성되었습니다.", Name);
		}

		public bool PutUnit(TerranUnit terranUnit)
		{
			if (unitList.Count >= CAPACITY) {
				Console.WriteLine("수용인원이 다 찼습니다. unitList.Count: {0}", unitList.Count);
				return false;
			}
			if (terranUnit.IsInBunker)
			{
				Console.WriteLine("{0}.{1} : 이미 벙커안에 있습니다.", terranUnit.GetName(), terranUnit.GetUnitCode());
				return false;
			}

			unitList.Add(terranUnit);
			terranUnit.IsInBunker = true;
			Console.WriteLine("{0}.{1} : 벙커에 들어갔습니다.", terranUnit.GetName(), terranUnit.GetUnitCode());

			return true;
		}

		public void TakeOutAllUnits()
		{
			foreach (TerranUnit terranUnit in unitList)
			{
				terranUnit.IsInBunker = false;
				Console.WriteLine("{0}.{1} : 벙커에서 나왔습니다.", terranUnit.GetName(), terranUnit.GetUnitCode());
			}
			unitList.Clear();
		}

	}
}
