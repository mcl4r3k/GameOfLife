using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace GameOfLife
{
	public class main
	{
		public static void Main()
		{

			int generation = Convert.ToInt32(Console.ReadLine ());
			int boardsize = Convert.ToInt32(Console.ReadLine ());

			Connways test = new Connways();
			Board gameboard = new Board(boardsize, boardsize);
			int[,] currentboard = gameboard.FillGameboard();
			int[,] nextgenboard = new int[boardsize, boardsize];


			for (int s = 0; s <= generation; s++)
			{
				gameboard.OutputBoard(currentboard);
				Thread.Sleep(1000);
				Console.Clear();
				currentboard = test.connwaysRules(currentboard, nextgenboard);






			}
		}


	}
}