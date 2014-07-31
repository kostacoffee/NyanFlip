using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NyanFlip
{
	struct Position
	{
		public int x;
		public int y;
		public Position(int x, int y) : this() {
			this.x = x;
			this.y = y;
		}
	}

	class Game
	{
		
		static void Main(string[] args)
		{
			runGame(parseBoard(setupBoard()));

		}



		static private void runGame(CellObject[][] board) {
			Cat cat = new Cat();
			while (true) {
				cat.move();
				if (!inBounds(cat, board)) break;
				Position p = cat.getPosition();
				board[p.y][p.x].apply(cat);
			}
			Console.ReadLine();

		}

		static private bool inBounds(Cat cat, CellObject[][] board) {
			Position p = cat.getPosition();
			if (p.y < 0 || p.y > board.Length-1 || p.x < 0 || p.x > board[0].Length-1) return false;
			return true;
		}

		static private CellObject[][] parseBoard(char[][] rawBoard) {
			CellObject[][] board = new CellObject[rawBoard.Length][];
			for (int i = 0; i < rawBoard.Length; i++)
			{
				CellObject[] row = new CellObject[rawBoard[0].Length];
				for (int j = 0; j < row.Length; j++) {
					switch (rawBoard[i][j]) { 
						case '>' :
							row[j] = new Arrow(new Direction(1, 0));
							break;

						case '<' :
							row[j] = new Arrow(new Direction(-1, 0));
							break;
						
						case '^' :
							row[j] = new Arrow(new Direction(0, -1));
							break;

						case 'V' :
							row[j] = new Arrow(new Direction(0, 1));
							break;

						case '\\':
							row[j] = new Mirror(false);
							break;

						case '+':
							row[j] = new ScoreModifier(1);
							break;

						case '-':
							row[j] = new ScoreModifier(-1);
							break;

						case '.':
							row[j] = new Checkpoint();
							break;

						case ' ':
							row[j] = new CellObject();
							break;
					}
					
				}
				board[i] = row;
			}
			return board;
		}

		static private char[][] setupBoard()
		{
			List<char[]> rawBoard = new List<char[]>();
			StreamReader file = new StreamReader("board.txt");
			string line;
			while ((line = file.ReadLine()) != null) 
				rawBoard.Add(line.ToCharArray());
			return rawBoard.ToArray();
		}
	}
}
