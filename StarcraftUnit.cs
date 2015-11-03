using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStarcraft05
{
	public abstract class StarcraftUnit
	{
		// 수시로 바뀌는 정보
		public int Strength { get; set; }

		// 한번 설정되면 바뀔일 없음
		public abstract string GetName();
		public abstract string GetClan();
		public abstract int GetUnitCode();

		// 모든 유닛이 구현해야 하는 기능적인 요소
		public abstract void Move();
		public abstract void Attack();
	}
}
