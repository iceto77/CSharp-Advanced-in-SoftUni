using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rowscols = int.Parse(input);
            int[,] myMatrix = new int[rowscols, rowscols];
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                input = Console.ReadLine();
                int[] currentRow = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < myMatrix.GetLength(0); j++)
                {
                    myMatrix[i, j] = currentRow[j];
                }
            }
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                primaryDiagonal += myMatrix[i, i];
                secondaryDiagonal += myMatrix[i, myMatrix.GetLength(1) - 1 - i];
            }
            int diagonalDifference = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(diagonalDifference);
        }
    }
}
