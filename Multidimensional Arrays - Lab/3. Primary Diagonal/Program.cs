using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rowcol = int.Parse(input);            
            int[,] myMatrix = new int[rowcol, rowcol];
            for (int i = 0; i < rowcol; i++)
            {
                input = Console.ReadLine();
                int[] currentRow = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < rowcol; j++)
                {
                    myMatrix[i, j] = currentRow[j];
                }
            }
            int primaryDiagonal = 0;
            for (int i = 0; i < rowcol; i++)
            {
                primaryDiagonal += myMatrix[i, i];
            }
            Console.WriteLine(primaryDiagonal);
        }
    }
}
