using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanFlip
{
	class Checkpoint : CellObject
	{
		public Checkpoint() : base() { }

		public override void apply(Cat cat) {
			cat.printScore();
		}
	}
}
