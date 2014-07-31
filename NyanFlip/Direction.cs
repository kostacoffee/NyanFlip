using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanFlip
{
	class Direction
	{
		int[] dir;

		public Direction(int right, int down)
		{
			this.dir = new int[2] {right, down};
		}

		public void move(Cat cat) {
			Position pos = cat.getPosition();
			pos.x += dir[0];
			pos.y += dir[1];
			cat.setPosition(pos);
		}

		internal void changePath()
		{
			int temp = dir[0];
			dir[0] = dir[1];
			dir[1] = temp;
		}

		internal void changeDirection()
		{
			dir[0] *= -1;
			dir[1] *= -1;
		}
	}
}
