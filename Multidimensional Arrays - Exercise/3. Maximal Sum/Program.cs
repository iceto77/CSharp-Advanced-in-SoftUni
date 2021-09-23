using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] rowscols = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowscols[0];
            int cols = rowscols[1];
            int[,] myMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine();
                int[] curentLine = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    myMatrix[i, j] = curentLine[j];
                }
            }
            int maximalSum = int.MinValue;
            int currentSum = 0;
            int[] maximalSumStartIndex = new int[2];
            for (int i = 0; i < myMatrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1) - 2; j++)
                {
                    currentSum = myMatrix[i, j] + myMatrix[i, j + 1] + myMatrix[i, j + 2]
                               + myMatrix[i + 1, j] + myMatrix[i + 1, j + 1] + myMatrix[i + 1, j + 2]
                               + myMatrix[i + 2, j] + myMatrix[i + 2, j + 1] + myMatrix[i + 2, j + 2];
                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        maximalSumStartIndex = new int[2] { i, j };
                    }
                }
            }
            Console.WriteLine($"Sum = {maximalSum}");
            for (int i = maximalSumStartIndex[0]; i < maximalSumStartIndex[0] + 3; i++)
            {
                for (int j = maximalSumStartIndex[1]; j < maximalSumStartIndex[1] + 3; j++)
                {
                    Console.Write($"{myMatrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
