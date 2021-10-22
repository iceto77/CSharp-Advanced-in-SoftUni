using System;
using System.Text;
using System.Linq;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lifeOfMarios = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[][] castle = new char[n][];
            int rowMario = 0;
            int colMario = 0;
            for (int i = 0; i < n; i++)
            {
                castle[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < castle[i].Length; j++)
                {
                    if (castle[i][j] == 'M')
                    {
                        rowMario = i;
                        colMario = j;
                    }
                }
            }
            bool isMarioDied = false;
            while (lifeOfMarios > 0)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                castle[rowMario][colMario] = '-';
                castle[row][col] = 'B';
                if (command[0] == "W")
                {
                    if (rowMario > 0)
                    {
                        rowMario--;
                    }
                }
                else if (command[0] == "S")
                {
                    if (rowMario < n - 1)
                    {
                        rowMario++;
                    }
                }
                else if (command[0] == "A")
                {
                    if (colMario > 0)
                    {
                        colMario--;
                    }
                }
                else if (command[0] == "D")
                {
                    if (colMario < castle[rowMario].Length - 1)
                    {
                        colMario++;
                    }
                }
                lifeOfMarios--;
                if (castle[rowMario][colMario] == 'B')
                {
                    lifeOfMarios -= 2;
                    castle[rowMario][colMario] = '-';
                    if (lifeOfMarios <= 0)
                    {
                        castle[rowMario][colMario] = 'X';
                        isMarioDied = true;
                        break;
                    }
                }
                if (castle[rowMario][colMario] == 'P')
                {
                    castle[rowMario][colMario] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lifeOfMarios}");
                    break;
                }
                castle[rowMario][colMario] = 'M';
                if (lifeOfMarios <= 0)
                {
                    isMarioDied = true;
                    castle[rowMario][colMario] = 'X';
                }
            }
            if (isMarioDied)
            {
                Console.WriteLine($"Mario died at {rowMario};{colMario}.");
            }
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < castle[i].Length; j++)
                {
                    sb.Append(castle[i][j]);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().TrimEnd());

        }
    }
}
