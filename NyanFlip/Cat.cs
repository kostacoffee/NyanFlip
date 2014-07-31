using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanFlip
{
	class Cat
	{
		Direction dir;
		int score;
		Position pos;

		public Cat(int x = 0, int y = 0) {
			this.dir = new Direction(1, 0);
			this.score = 0;
			pos = new Position(x, y);
		}

		internal void changeDirection(Direction dir)
		{
			this.dir = dir;
		}

		internal Direction getDirection()
		{
			return dir;
		}

		internal void changeScore(int change)
		{
			this.score += change;
		}

		public void move() {
			dir.move(this);
			//Console.WriteLine(pos.x.ToString() + ", " + pos.y.ToString());
		}


		internal void printScore()
		{
			string alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
			System.Console.WriteLine(alphabet[this.score-1]);
		}

		internal Position getPosition()
		{
			return this.pos;		
		}

		public void setPosition(Position pos) {
			this.pos = pos;
		}
	}
}
