using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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
                int[] currentRow = input.Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    myMatrix[i, j] = currentRow[j];
                }
            }
            int sum = 0;
            foreach (var item in myMatrix)
            {
                sum += item;
            }
            Console.WriteLine(myMatrix.GetLength(0));
            Console.WriteLine(myMatrix.GetLength(1));
            Console.WriteLine(sum);

        }
    }
}
