using System;
using System.Text;
using System.Linq;

namespace Armory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var officer = (row: 0, col: 0);
            char[][] armory = new char[n][];
            for (int i = 0; i < n; i++)
            {
                armory[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    if (armory[i][j] == 'A')
                    {
                        officer.row = i;
                        officer.col = j;
                    }
                }
            }
            int kingCoins = 0;
            while (kingCoins < 65)
            {
                string command = Console.ReadLine();
                armory[officer.row][officer.col] = '-';
                if (command == "right")
                {
                    if (NewPositionIsOut(officer.row, officer.col + 1, armory))
                    {
                        break;
                    }
                    if (armory[officer.row][officer.col + 1] == '-')
                    {
                        armory[officer.row][officer.col + 1] = 'A';
                        officer.col++;
                    }
                    else if (armory[officer.row][officer.col + 1] == 'M')
                    {
                        armory[officer.row][officer.col + 1] = '-';
                        officer = GoThroughTheMirror(armory);
                    }
                    else
                    {
                        int sword = int.Parse(armory[officer.row][officer.col + 1].ToString());
                        kingCoins += sword;
                        armory[officer.row][officer.col + 1] = 'A';
                        officer.col++;
                    }
                }
                else if (command == "left")
                {
                    if (NewPositionIsOut(officer.row, officer.col - 1, armory))
                    {
                        break;
                    }
                    if (armory[officer.row][officer.col - 1] == '-')
                    {
                        armory[officer.row][officer.col - 1] = 'A';
                        officer.col--;
                    }
                    else if (armory[officer.row][officer.col - 1] == 'M')
                    {
                        armory[officer.row][officer.col - 1] = '-';
                        officer = GoThroughTheMirror(armory);
                    }
                    else
                    {
                        int sword = int.Parse(armory[officer.row][officer.col - 1].ToString());
                        kingCoins += sword;
                        armory[officer.row][officer.col - 1] = 'A';
                        officer.col--;
                    }
                }
                else if (command == "up")
                {
                    if (NewPositionIsOut(officer.row -1, officer.col, armory))
                    {
                        break;
                    }
                    if (armory[officer.row - 1][officer.col] == '-')
                    {
                        armory[officer.row - 1][officer.col] = 'A';
                        officer.row--;
                    }
                    else if (armory[officer.row - 1][officer.col] == 'M')
                    {
                        armory[officer.row - 1][officer.col] = '-';
                        officer = GoThroughTheMirror(armory);
                    }
                    else
                    {
                        int sword = int.Parse(armory[officer.row - 1][officer.col].ToString());
                        kingCoins += sword;
                        armory[officer.row - 1][officer.col] = 'A';
                        officer.row--;
                    }
                }
                else if (command == "down")
                {
                    if (NewPositionIsOut(officer.row + 1, officer.col, armory))
                    {
                        break;
                    }
                    if (armory[officer.row + 1][officer.col] == '-')
                    {
                        armory[officer.row + 1][officer.col] = 'A';
                        officer.row++;
                    }
                    else if (armory[officer.row + 1][officer.col] == 'M')
                    {
                        armory[officer.row + 1][officer.col] = '-';
                        officer = GoThroughTheMirror(armory);
                    }
                    else
                    {
                        int sword = int.Parse(armory[officer.row + 1][officer.col].ToString());
                        kingCoins += sword;
                        armory[officer.row + 1][officer.col] = 'A';
                        officer.row++;
                    }
                }
            }
            if (kingCoins < 65)
            {
                Console.WriteLine("I do not need more swords!");
            }
            else
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }
            Console.WriteLine($"The king paid {kingCoins} gold coins.");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(armory[i][j]);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().TrimEnd());

        }

        private static (int row, int col) GoThroughTheMirror(char[][] armory)
        {
            var result = (row: 0, col: 0);

            for (int i = 0; i < armory.GetLength(0); i++)
            {
                for (int j = 0; j < armory.Length; j++)
                {
                    if (armory[i][j] == 'M')
                    {
                        armory[i][j] = 'A';
                        result.row = i;
                        result.col = j;
                        return result;
                    }
                }
            }
            return result;
        }

        private static bool NewPositionIsOut(int row, int col, char[][] armory)
        {
            if (row >= armory.Length)
            {
                return true;
            }
            if (row < 0)
            {
                return true;
            }
            if (col >= armory.Length)
            {
                return true;
            }
            if (col < 0)
            {
                return true;
            }
            return false;
        }
    }
}
