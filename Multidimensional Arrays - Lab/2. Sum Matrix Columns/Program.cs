using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
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
                int[] currentRow = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    myMatrix[i, j] = currentRow[j];
                }
            }
            for (int i = 0; i < myMatrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < myMatrix.GetLength(0); j++)
                {
                    sum += myMatrix[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
