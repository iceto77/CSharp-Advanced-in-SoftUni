using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input);
            double[][] myMatrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine();
                double[] currentRow = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                myMatrix[i] = currentRow;
            }
            for (int i = 0; i < rows - 1; i++)
            {
                if (myMatrix[i].Length == myMatrix[i + 1].Length)
                {
                    for (int j = 0; j < myMatrix[i].Length; j++)
                    {
                        myMatrix[i][j] *= 2;
                        myMatrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < myMatrix[i].Length; j++)
                    {
                        myMatrix[i][j] /= 2;
                    }
                    for (int j = 0; j < myMatrix[i + 1].Length; j++)
                    {
                        myMatrix[i + 1][j] /= 2;
                    }
                }
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (command[0] == "Add")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < myMatrix[row].Length)
                    {
                        myMatrix[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < myMatrix[row].Length)
                    {
                        myMatrix[row][col] -= value;
                    }
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < myMatrix[i].Length; j++)
                {
                    Console.Write($"{myMatrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
