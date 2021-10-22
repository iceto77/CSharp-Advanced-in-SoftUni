using System;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] gameboard = new char[n][];
            int snakeRow = 0;
            int snakeCol = 0;
            for (int i = 0; i < n; i++)
            {
                char[] boardRow = Console.ReadLine().ToCharArray();
                gameboard[i] = boardRow;
                for (int j = 0; j < boardRow.Length; j++)
                {
                    if (gameboard[i][j] == 'S')
                    {
                        snakeRow = i;
                        snakeCol = j;
                    }
                }
            }
            int foodQuantity = 0;
            while (true)
            {
                string command = Console.ReadLine();
                gameboard[snakeRow][snakeCol] = '.';
                switch (command)
                {
                    case "up":
                        snakeRow--;
                        break;
                    case "down":
                        snakeRow++;
                        break;
                    case "left":
                        snakeCol--;
                        break;
                    case "right":
                        snakeCol++;
                        break;
                }
                if (snakeRow >= 0 && snakeRow < n && snakeCol >= 0 && snakeCol < gameboard[snakeRow].Length)
                {
                    if (gameboard[snakeRow][snakeCol] == 'B')
                    {
                        gameboard[snakeRow][snakeCol] = '.';
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < gameboard[i].Length; j++)
                            {
                                if (gameboard[i][j] == 'B')
                                {
                                    snakeRow = i;
                                    snakeCol = j;
                                    gameboard[i][j] = 'S';
                                }
                            }
                        }
                    }
                    else if (gameboard[snakeRow][snakeCol] == '*')
                    {
                        foodQuantity++;
                        gameboard[snakeRow][snakeCol] = 'S';
                        if (foodQuantity >= 10)
                        {
                            Console.WriteLine("You won! You fed the snake.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Game over!");
                    break;
                }
            }
            Console.WriteLine($"Food eaten: {foodQuantity}");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join("", gameboard[i]));
            }
        }
    }
}
