using System;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] beach = new char[n][];
            for (int i = 0; i < n; i++)
            {
                char[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                beach[i] = tokens;
            }
            int countOfCollected = 0;
            int countOfOpponentsTokens = 0;
            string input = Console.ReadLine();
            while (input != "Gong")
            {
                string[] command = input.Split();
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                if (row >= 0 && row < n && col >= 0 && col < beach[row].Length)
                {
                    if (command[0] == "Find")
                    {
                        if (beach[row][col] == 'T')
                        {
                            countOfCollected++;
                            beach[row][col] = '-';
                        }
                    }
                    else if (command[0] == "Opponent")
                    {
                        if (beach[row][col] == 'T')
                        {
                            countOfOpponentsTokens++;
                            beach[row][col] = '-';
                        }
                        if (command[3] == "up")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                if (row - i >= 0 && col < beach[row - i].Length)
                                {
                                    if (beach[row - i][col] == 'T')
                                    {
                                        countOfOpponentsTokens++;
                                        beach[row - i][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (command[3] == "down")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                if (row + i < n && col < beach[row + i].Length)
                                {
                                    if (beach[row + i][col] == 'T')
                                    {
                                        countOfOpponentsTokens++;
                                        beach[row + i][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (command[3] == "left")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                if (col - i >= 0)
                                {
                                    if (beach[row][col - i] == 'T')
                                    {
                                        countOfOpponentsTokens++;
                                        beach[row][col - i] = '-';
                                    }
                                }
                            }
                        }
                        else if (command[3] == "right")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                if (col + i < beach[row].Length)
                                {
                                    if (beach[row][col + i] == 'T')
                                    {
                                        countOfOpponentsTokens++;
                                        beach[row][col + i] = '-';
                                    }
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", beach[i]));
            }
            Console.WriteLine($"Collected tokens: {countOfCollected}");
            Console.WriteLine($"Opponent's tokens: {countOfOpponentsTokens}");
        }
    }
}
