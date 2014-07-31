using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanFlip
{
	class ScoreModifier : CellObject
	{
		int scoreChange;

		public ScoreModifier(int scoreChange) : base() {
			this.scoreChange = scoreChange;
		}

		public override void apply(Cat cat)
		{
			cat.changeScore(scoreChange);
			//Console.WriteLine("Score modified by: " + SCORE_CHANGE.ToString());
		}

	}
}
