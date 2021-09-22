using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] rowscols = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowscols[0];
            int cols = rowscols[1];
            char[,] myMatrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine();
                char[] curentLine = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    myMatrix[i, j] = curentLine[j];
                }
            }
            int squaresOfEqualChars = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (myMatrix[i,j] == myMatrix[i + 1, j] && myMatrix[i, j] == myMatrix[i, j + 1] && myMatrix[i, j] == myMatrix[i + 1, j + 1])
                    {
                        squaresOfEqualChars++;
                    }
                }
            }
            Console.WriteLine(squaresOfEqualChars);
        }
    }
}
