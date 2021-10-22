using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] attacks = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> plaersAttack = new Queue<string>();
            for (int i = 0; i < attacks.Length; i++)
            {
                plaersAttack.Enqueue(attacks[i]);
            }
            int countOfShipsPlayerOne = 0;
            int countOfShipsPlayerTwo = 0;
            int totalCountShipsDestroyed = 0;
            char[,] batleField = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                char[] field = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    batleField[i, j] = field[j];
                    if (batleField[i, j] == '<')
                    {
                        countOfShipsPlayerOne++;
                    }
                    else if (batleField[i, j] == '>')
                    {
                        countOfShipsPlayerTwo++;
                    }
                }
            }
            while (plaersAttack.Count > 0)
            {
                int[] coordinates = plaersAttack.Dequeue().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = coordinates[0];
                int col = coordinates[1];
                if (ChekCoordinates(row, col, batleField))
                {
                    if (ChekForPlayerShip(1, row, col, batleField))
                    {
                        countOfShipsPlayerOne--;
                        totalCountShipsDestroyed++;
                        batleField[row, col] = 'X';
                    }
                    else if (ChekForPlayerShip(2, row, col, batleField))
                    {
                        countOfShipsPlayerTwo--;
                        totalCountShipsDestroyed++;
                        batleField[row, col] = 'X';
                    }
                    if (batleField[row, col] == '#')
                    {
                        batleField[row, col] = 'X';
                        if (ChekCoordinates(row - 1, col - 1, batleField))
                        {
                            if (ChekForPlayerShip(1, row - 1, col - 1, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row - 1, col - 1, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                        if (ChekCoordinates(row - 1, col, batleField))
                        {
                            if (ChekForPlayerShip(1, row - 1, col, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row - 1, col, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                        if (ChekCoordinates(row - 1, col + 1, batleField))
                        {
                            if (ChekForPlayerShip(1, row - 1, col + 1, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row - 1, col + 1, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                        if (ChekCoordinates(row, col - 1, batleField))
                        {
                            if (ChekForPlayerShip(1, row, col - 1, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row, col - 1, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                        if (ChekCoordinates(row, col + 1, batleField))
                        {
                            if (ChekForPlayerShip(1, row, col + 1, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row, col + 1, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                        if (ChekCoordinates(row + 1, col - 1, batleField))
                        {
                            if (ChekForPlayerShip(1, row + 1, col - 1, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row + 1, col - 1, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                        if (ChekCoordinates(row + 1, col, batleField))
                        {
                            if (ChekForPlayerShip(1, row + 1, col, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row + 1, col, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                        if (ChekCoordinates(row + 1, col + 1, batleField))
                        {
                            if (ChekForPlayerShip(1, row + 1, col + 1, batleField))
                            {
                                countOfShipsPlayerOne--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                            else if (ChekForPlayerShip(2, row + 1, col + 1, batleField))
                            {
                                countOfShipsPlayerTwo--;
                                totalCountShipsDestroyed++;
                                batleField[row, col] = 'X';
                            }
                        }
                    }
                    if (countOfShipsPlayerOne <= 0 || countOfShipsPlayerTwo <= 0)
                    {
                        break;
                    }
                }
            }

            if (countOfShipsPlayerOne > 0 && countOfShipsPlayerTwo > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {countOfShipsPlayerOne} ships left. Player Two has {countOfShipsPlayerTwo} ships left.");
            }
            else if (countOfShipsPlayerTwo <= 0)
            {
                Console.WriteLine($"Player One has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
            }
            else if (countOfShipsPlayerOne <= 0)
            {
                Console.WriteLine($"Player Two has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
            }
        }

        private static bool ChekForPlayerShip(int player, int row, int col, char[,] batleField)
        {
            if (batleField[row, col] == '<' && player == 1)
            {
                return true;
            }
            else if (batleField[row, col] == '>' && player == 2)
            {
                return true;
            }
            return false;
        }
        private static bool ChekCoordinates(int row, int col, char[,] batleField)
        {
            if (row >= 0 && row < batleField.GetLength(0) && col >= 0 && col < batleField.GetLength(1))
            {
                return true;
            }
            return false;

        }
    }
}
