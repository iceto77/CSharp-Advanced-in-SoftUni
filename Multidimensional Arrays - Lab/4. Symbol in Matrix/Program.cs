using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rowcol = int.Parse(input);
            char[,] myMatrix = new char[rowcol, rowcol];
            for (int i = 0; i < rowcol; i++)
            {
                input = Console.ReadLine();
                for (int j = 0; j < rowcol; j++)
                {
                    myMatrix[i, j] = input[j];
                }
            }
            input = Console.ReadLine();
            char target = char.Parse(input);
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    if (myMatrix[i,j] == target)
                    {
                        Console.WriteLine($"({i}, {j})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{target} does not occur in the matrix ");
        }
    }
}
