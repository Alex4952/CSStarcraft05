using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStarcraft05
{
	class Firebat : TerranUnit
	{
		private int unitCode;
		private string name;

		public bool IsSteamPackOn { get; set; }

		public Firebat(int unitCode, int strength)
		{
			this.name = "Firebat";
			base.Strength = strength;
			this.unitCode = unitCode;
			Console.WriteLine("{0}.{1} : 생성되었습니다.", GetName(), GetUnitCode());
		}

		public override void Attack()
		{
			Console.WriteLine("{0}.{1} 공격중", name, GetUnitCode());
		}

		public override void Move()
		{
			Console.WriteLine("{0}.{1} 이동중", name, GetUnitCode());
		}

		public override string GetName()
		{
			return this.name;
		}

		public override int GetUnitCode()
		{
			return this.unitCode;
		}
	}
}
