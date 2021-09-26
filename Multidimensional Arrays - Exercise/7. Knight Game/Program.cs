using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rowscols = int.Parse(input);
            char[,] myMatrix = new char[rowscols, rowscols];
            for (int i = 0; i < rowscols; i++)
            {
                input = Console.ReadLine();
                for (int j = 0; j < rowscols; j++)
                {
                    myMatrix[i, j] = input[j];
                }
            }
            int removedKnights = 0;
            int currenPossibleHits = 0;
            int maxPossibleHits = 0;
            int maxRowValue = int.MinValue;
            int maxColValue = int.MinValue;
            while (true)
            {
                for (int i = 0; i < rowscols; i++)
                {
                    for (int j = 0; j < rowscols; j++)
                    {
                        if (myMatrix[i, j] == 'K')
                        {
                            if (IsOnBoard(myMatrix, i - 2, j - 1) && myMatrix[i - 2, j - 1] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (IsOnBoard(myMatrix, i - 2, j + 1) && myMatrix[i - 2, j + 1] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (IsOnBoard(myMatrix, i - 1, j - 2) && myMatrix[i - 1, j - 2] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (IsOnBoard(myMatrix, i - 1, j + 2) && myMatrix[i - 1, j + 2] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (IsOnBoard(myMatrix, i + 1, j - 2) && myMatrix[i + 1, j - 2] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (IsOnBoard(myMatrix, i + 1, j + 2) && myMatrix[i + 1, j + 2] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (IsOnBoard(myMatrix, i + 2, j - 1) && myMatrix[i + 2, j - 1] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (IsOnBoard(myMatrix, i + 2, j + 1) && myMatrix[i + 2, j + 1] == 'K')
                            {
                                currenPossibleHits++;
                            }
                            if (currenPossibleHits > maxPossibleHits)
                            {
                                maxPossibleHits = currenPossibleHits;
                                maxRowValue = i;
                                maxColValue = j;
                            }
                        }
                        currenPossibleHits = 0;
                    }
                }
                if (maxPossibleHits > 0)
                {
                    myMatrix[maxRowValue, maxColValue] = 'O';
                    removedKnights++;
                    maxPossibleHits = 0;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(removedKnights);
        }

        private static bool IsOnBoard(char[,] myMatrix, int row, int col)
        {
            if (row >= 0 && row < myMatrix.GetLength(0) && col >= 0 && col < myMatrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
