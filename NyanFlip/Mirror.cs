using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanFlip
{
	class Mirror : CellObject
	{
		bool directionChanger; //when the mirror is '/' , the direciton of the cat is changed, as well as the path. i.e. (vertical to horizontal AND positive to negative)

		public Mirror(bool directionChanger) : base() {
			this.directionChanger = directionChanger;
		}

		public override void apply(Cat cat) {
			if (directionChanger) cat.getDirection().changeDirection();
			cat.getDirection().changePath();
			directionChanger = !directionChanger;
			//Console.WriteLine("Hit Mirror");
		}

	}
}
