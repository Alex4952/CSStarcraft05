using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStarcraft05
{
	public abstract class TerranUnit : StarcraftUnit
	{
		private string clan = "Terran";

		public bool IsInBunker { get; set; }

		public override string GetClan()
		{
			return clan;
		}

	}
}
