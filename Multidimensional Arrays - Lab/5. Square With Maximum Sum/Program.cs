using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] rowcol = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowcol[0];
            int columns = rowcol[1];
            int[,] myMatrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine();
                int[] currentRow = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    myMatrix[i, j] = currentRow[j];
                }
            }
            int currentSum = 0;
            int maxSquareSum = int.MinValue;
            int[] maxSquare = new int[2];
            for (int i = 0; i < myMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1) - 1; j++)
                {
                    currentSum = myMatrix[i, j] + myMatrix[i + 1, j] + myMatrix[i, j + 1] + myMatrix[i + 1, j + 1];
                    if (currentSum > maxSquareSum)
                    {
                        maxSquareSum = currentSum;
                        maxSquare = new int[] {i, j};
                    }
                }
            }
            Console.WriteLine($"{myMatrix[maxSquare[0], maxSquare[1]]} {myMatrix[maxSquare[0], maxSquare[1] + 1]}");
            Console.WriteLine($"{myMatrix[maxSquare[0] + 1, maxSquare[1]]} {myMatrix[maxSquare[0] + 1, maxSquare[1] + 1]}");
            Console.WriteLine(maxSquareSum);
        }
    }
}
