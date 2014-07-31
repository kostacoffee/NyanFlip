using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanFlip
{
	class Arrow : CellObject
	{
		Direction dir;

		public Arrow(Direction dir) : base() {
			this.dir = dir;
		}

		public override void apply(Cat cat) {
			Direction catDir = cat.getDirection();
			cat.changeDirection(this.dir);
			this.dir = catDir;
			dir.changeDirection();
			//Console.WriteLine("Hit Arrow");
		}
	}
}
