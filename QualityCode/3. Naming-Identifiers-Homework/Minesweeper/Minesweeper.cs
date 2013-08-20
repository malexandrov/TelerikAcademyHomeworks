using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
	public class Minesweeper
	{
		static void Main()
		{
            const int MaxScore = 35;

			string parsedCommand = string.Empty;
            List<Player> highScores = new List<Player>(6);
            int pointsCount = 0;
            int row = 0;
			int col = 0;
            bool gameStart = true;
            bool gameWon = false;
            bool cellIsMine = false;
            char[,] gameField = CreateGameField();
            char[,] minesField = PlaceBombs();

			do
			{
				if (gameStart)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					DrawGameField(gameField);
					gameStart = false;
				}
				Console.Write("Daj red i kolona : ");
				parsedCommand = Console.ReadLine().Trim();

				if (parsedCommand.Length >= 3)
				{
					if (int.TryParse(parsedCommand[0].ToString(), out row) &&
					int.TryParse(parsedCommand[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
					{
						parsedCommand = "turn";
					}
				}

				switch (parsedCommand)
				{
                    case "top":
                        {
                            HighScores(highScores);
                            break;
                        }
                    case "restart":
                        {
                            gameField = CreateGameField();
                            minesField = PlaceBombs();
                            DrawGameField(gameField);
                            cellIsMine = false;
                            gameStart = false;
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("4a0, 4a0, 4a0!");
                            break;
                        }
                    case "turn":
                        {
                            if (minesField[row, col] != '*')
                            {
                                if (minesField[row, col] == '-')
                                {
                                    PlayTurn(gameField, minesField, row, col);
                                    pointsCount++;
                                }
                                if (MaxScore == pointsCount)
                                {
                                    gameWon = true;
                                }
                                else
                                {
                                    DrawGameField(gameField);
                                }
                            }
                            else
                            {
                                cellIsMine = true;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                            break;
                        }
				}

				if (cellIsMine)
				{
					DrawGameField(minesField);

					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", pointsCount);
					string nickName = Console.ReadLine();
					Player player = new Player(nickName, pointsCount);

					if (highScores.Count < 5)
					{
						highScores.Add(player);
					}
					else
					{
						for (int i = 0; i < highScores.Count; i++)
						{
							if (highScores[i].Points < player.Points)
							{
								highScores.Insert(i, player);
								highScores.RemoveAt(highScores.Count - 1);
								break;
							}
						}
					}

                    highScores.Sort((Player player1, Player player2) => player2.NickName.CompareTo(player1.NickName));
                    highScores.Sort((Player player1, Player player2) => player2.Points.CompareTo(player1.Points));
					HighScores(highScores);

                    gameField = CreateGameField();
					minesField = PlaceBombs();
					pointsCount = 0;
					cellIsMine = false;
					gameStart = true;
				}

				if (gameWon)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					DrawGameField(minesField);

					Console.WriteLine("Daj si imeto, batka: ");
					string playerName = Console.ReadLine();
					Player points = new Player(playerName, pointsCount);
					highScores.Add(points);
					HighScores(highScores);

                    gameField = CreateGameField();
					minesField = PlaceBombs();
					pointsCount = 0;
					gameWon = false;
					gameStart = true;
				}
			}
			while (parsedCommand != "exit");

			Console.Read();
		}

        static void HighScores(List<Player> scores)
        {
            Console.WriteLine("\nTochki:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, scores[i].NickName, scores[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

		private static void PlayTurn(char[,] gameField,
			char[,] minesField, int row, int col)
		{
			char minesCount = GetAdjacentMinesCount(minesField, row, col);
			minesField[row, col] = minesCount;
			gameField[row, col] = minesCount;
		}

		private static void DrawGameField(char[,] board)
		{
			int row = board.GetLength(0);
			int col = board.GetLength(1);

			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < row; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < col; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int fieldRows = 5;
			int fieldColumns = 10;
			char[,] gameField = new char[fieldRows, fieldColumns];
			for (int i = 0; i < fieldRows; i++)
			{
				for (int j = 0; j < fieldColumns; j++)
				{
					gameField[i, j] = '?';
				}
			}

			return gameField;
		}

		private static char[,] PlaceBombs()
		{
			int rows = 5;
			int cols = 10;
			char[,] gameField = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					gameField[i, j] = '-';
				}
			}

			List<int> r3 = new List<int>();

			while (r3.Count < 15)
			{
				Random random = new Random();
				int asfd = random.Next(50);
				if (!r3.Contains(asfd))
				{
					r3.Add(asfd);
				}
			}

			foreach (int i2 in r3)
			{
				int col = (i2 / cols);
				int row = (i2 % cols);
				if (row == 0 && i2 != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				gameField[col, row - 1] = '*';
			}

			return gameField;
		}

		private static void PlaceMinesCount(char[,] gameField)
		{
			int col = gameField.GetLength(0);
			int row = gameField.GetLength(1);

			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (gameField[i, j] != '*')
					{
						char minesCount = GetAdjacentMinesCount(gameField, i, j);
						gameField[i, j] = minesCount;
					}
				}
			}
		}

		private static char GetAdjacentMinesCount(char[,] gameField, int row, int col)
		{
			int minesCount = 0;
			int gameFieldRows = gameField.GetLength(0);
			int gameFieldCols = gameField.GetLength(1);

			if (row - 1 >= 0)
			{
				if (gameField[row - 1, col] == '*')
				{ 
					minesCount++; 
				}
			}
			if (row + 1 < gameFieldRows)
			{
				if (gameField[row + 1, col] == '*')
				{ 
					minesCount++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (gameField[row, col - 1] == '*')
				{ 
					minesCount++;
				}
			}
			if (col + 1 < gameFieldCols)
			{
				if (gameField[row, col + 1] == '*')
				{ 
					minesCount++;
				}
			}

			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (gameField[row - 1, col - 1] == '*')
				{ 
					minesCount++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < gameFieldCols))
			{
				if (gameField[row - 1, col + 1] == '*')
				{ 
					minesCount++; 
				}
			}
			if ((row + 1 < gameFieldRows) && (col - 1 >= 0))
			{
				if (gameField[row + 1, col - 1] == '*')
				{ 
					minesCount++; 
				}
			}
			if ((row + 1 < gameFieldRows) && (col + 1 < gameFieldCols))
			{
				if (gameField[row + 1, col + 1] == '*')
				{ 
					minesCount++; 
				}
			}

			return char.Parse(minesCount.ToString());
		}
	}
}

