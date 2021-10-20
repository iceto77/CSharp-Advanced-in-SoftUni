using System;
using System.Text;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            char[,] dashboard = new char[n, n];
            int playerRow = 0;
            int playerCol = 0;
            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    dashboard[i, j] = row[j];
                    if (dashboard[i, j] == 'f')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();
                dashboard[playerRow, playerCol] = '-';
                while (true)
                {
                    if (command == "up" || command == "down")
                    {
                        playerRow = PlayerMoving(command, playerRow, n);
                    }
                    if (command == "left" || command == "right")
                    {
                        playerCol = PlayerMoving(command, playerCol, n);
                    }
                    if (dashboard[playerRow, playerCol] == 'B')
                    {
                        continue;
                    }
                    if (dashboard[playerRow, playerCol] == 'T')
                    {
                        if (command == "up")
                        {
                            playerRow = PlayerMoving("down", playerRow, n);
                        }
                        else if (command == "down")
                        {
                            playerRow = PlayerMoving("up", playerRow, n);
                        }
                        else if (command == "left")
                        {
                            playerCol = PlayerMoving("right", playerCol, n);
                        }
                        else if (command == "right")
                        {
                            playerCol = PlayerMoving("left", playerCol, n);
                        }
                    }
                    break;
                }
                if (dashboard[playerRow, playerCol] == 'F')
                {
                    Console.WriteLine("Player won!");
                    dashboard[playerRow, playerCol] = 'f';
                    PrintDashboard(dashboard);
                    return;
                }
                else
                {
                    dashboard[playerRow, playerCol] = 'f';
                }
            }
            Console.WriteLine("Player lost!");
            PrintDashboard(dashboard);
        }

        private static void PrintDashboard(char[,] dashboard)
        {
            for (int i = 0; i < dashboard.GetLength(0); i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < dashboard.GetLength(0); j++)
                {
                    sb.Append(dashboard[i, j]);
                }
                Console.WriteLine(sb.ToString().TrimEnd());
            }
        }

        private static int PlayerMoving(string command, int move, int n)
        {
            if (command == "up")
            {
                if (move == 0)
                {
                    move = n - 1;
                }
                else
                {
                    move--;
                }
            }
            else if (command == "down")
            {
                if (move == n - 1)
                {
                    move = 0;
                }
                else
                {
                    move++;
                }
            }
            else if (command == "left")
            {
                if (move == 0)
                {
                    move = n - 1;
                }
                else
                {
                    move--;
                }
            }
            else if (command == "right")
            {
                if (move == n - 1)
                {
                    move = 0;
                }
                else
                {
                    move++;
                }
            }
            return move;
        }
    }
}

