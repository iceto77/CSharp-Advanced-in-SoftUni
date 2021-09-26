using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] rowscols = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowscols[0];
            int cols = rowscols[1];
            string[,] myMatrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine();
                string[] currentRow = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    myMatrix[i, j] = currentRow[j];
                }
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "swap" && command.Length == 5)
                {
                    int r1 = int.Parse(command[1]);
                    int c1 = int.Parse(command[2]);
                    int r2 = int.Parse(command[3]);
                    int c2 = int.Parse(command[4]);
                    if (r1 >= 0 && r1 < rows && r2 >= 0 && r2 < rows && c1 >= 0 && c1 < cols && c2 >= 0 && c2 < cols)
                    {
                        string temp = myMatrix[r1, c1];
                        myMatrix[r1, c1] = myMatrix[r2, c2];
                        myMatrix[r2, c2] = temp;
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                Console.Write($"{myMatrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }

        }
    }
}
