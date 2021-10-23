using System;

namespace _02.PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] chessboard = new char[8][];
            var pawnW = (row: 0, col: 0);
            var pawnB = (row: 0, col: 0);
            for (int i = 0; i < 8; i++)
            {
                chessboard[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    if (chessboard[i][j] == 'w')
                    {
                        pawnW.row = i;
                        pawnW.col = j;
                    }
                    if (chessboard[i][j] == 'b')
                    {
                        pawnB.row = i;
                        pawnB.col = j;
                    }
                }
            }
            while (true)
            {
                chessboard[pawnW.row][pawnW.col] = '-';
                if (pawnW.row - 1 == pawnB.row)
                {
                    if (pawnW.col + 1 == pawnB.col || pawnW.col - 1 == pawnB.col)
                    {
                        pawnW.row = pawnB.row;
                        pawnW.col = pawnB.col;
                        Console.WriteLine($"Game over! White capture on {ConvertCoordinates(pawnW.row, pawnW.col)}.");
                        chessboard[pawnW.row][pawnW.col] = 'w';
                        break;
                    }
                }
                pawnW.row--;
                chessboard[pawnW.row][pawnW.col] = 'w';
                if (pawnW.row == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {ConvertCoordinates(pawnW.row, pawnW.col)}.");
                    break;
                }

                chessboard[pawnB.row][pawnB.col] = '-';
                if (pawnB.row + 1 == pawnW.row)
                {
                    if (pawnB.col + 1 == pawnW.col || pawnB.col - 1 == pawnW.col)
                    {
                        pawnB.row = pawnW.row;
                        pawnB.col = pawnW.col;
                        Console.WriteLine($"Game over! Black capture on {ConvertCoordinates(pawnB.row, pawnB.col)}.");
                        chessboard[pawnB.row][pawnB.col] = 'b';
                        break;
                    }
                }
                pawnB.row++;
                chessboard[pawnB.row][pawnB.col] = 'b';
                if (pawnB.row == 7)
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {ConvertCoordinates(pawnB.row, pawnB.col)}.");
                    break;
                }
            }
        }

        private static string ConvertCoordinates(int row, int col)
        {
            char symbol = (char)(97 + col);

            return $"{symbol}{8 - row}";
        }
    }
}
