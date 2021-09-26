using System;
using System.Linq;

namespace _5._Snake_Moves
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
            string snake = Console.ReadLine();
            int snakeCount = 0;
            bool leftToRight = true;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (leftToRight)
                    {
                        myMatrix[i, j] = snake[snakeCount];
                    }
                    else
                    {
                        int x = cols - 1 - j;
                        myMatrix[i, x] = snake[snakeCount];
                    }
                    snakeCount++;
                    if (snakeCount == snake.Length)
                    {
                        snakeCount = 0;
                    }
                }
                if (leftToRight)
                {
                    leftToRight = false;
                }
                else
                {
                    leftToRight = true;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(myMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
