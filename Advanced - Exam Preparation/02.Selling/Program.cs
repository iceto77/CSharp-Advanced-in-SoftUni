using System;
using System.Text;

namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] bakery = new char[n][];
            int myRow = 0;
            int myCol = 0;
            for (int i = 0; i < n; i++)
            {
                bakery[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < bakery[i].Length; j++)
                {
                    if (bakery[i][j] == 'S')
                    {
                        myRow = i;
                        myCol = j;
                    }
                }
            }
            int savedMoney = 0;
            while (true)
            {
                string command = Console.ReadLine();
                bakery[myRow][myCol] = '-';
                switch (command)
                {
                    case "up":
                        myRow--;
                        break;
                    case "down":
                        myRow++;
                        break;
                    case "left":
                        myCol--;
                        break;
                    case "right":
                        myCol++;
                        break;
                }
                if (myRow >= 0 && myRow < n && myCol >= 0 && myCol < bakery[myRow].Length)
                {
                    if (bakery[myRow][myCol] == 'O')
                    {
                        bakery[myRow][myCol] = '-';
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < bakery[i].Length; j++)
                            {
                                if (bakery[i][j] == 'O')
                                {
                                    myRow = i;
                                    myCol = j;
                                    bakery[myRow][myCol] = 'S';
                                }
                            }
                        }
                    }
                    else if (bakery[myRow][myCol] != '-')
                    {
                        savedMoney += int.Parse(bakery[myRow][myCol].ToString());
                        bakery[myRow][myCol] = 'S';
                    }
                    else
                    {
                        bakery[myRow][myCol] = 'S';
                    }
                }
                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                if (savedMoney >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }
            }
            Console.WriteLine($"Money: {savedMoney}");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine(string.Join("", bakery[i]));
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
