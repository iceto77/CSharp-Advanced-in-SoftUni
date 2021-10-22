using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] beeTerritory = new char[n][];
            int beeRow = 0;
            int beeCol = 0;
            for (int i = 0; i < n; i++)
            {
                char[] curentRow = Console.ReadLine().ToCharArray();
                beeTerritory[i] = curentRow;
                for (int j = 0; j < curentRow.Length; j++)
                {
                    if (beeTerritory[i][j] == 'B')
                    {
                        beeRow = i;
                        beeCol = j;
                    }
                }
            }
            string input = Console.ReadLine();
            int polinationedFlowers = 0;
            while (input != "End")
            {
                beeTerritory[beeRow][beeCol] = '.';
                switch (input)
                {
                    case "up":
                        beeRow--;
                        break;
                    case "down":
                        beeRow++;
                        break;
                    case "left":
                        beeCol--;
                        break;
                    case "right":
                        beeCol++;
                        break;
                }
                if (beeRow >=0 && beeRow < n && beeCol >=0 && beeCol < beeTerritory[beeRow].Length)
                {
                    if (beeTerritory[beeRow][beeCol] == 'O')
                    {
                        continue;
                    }
                    else if (beeTerritory[beeRow][beeCol] == 'f')
                    {
                        polinationedFlowers++;
                        beeTerritory[beeRow][beeCol] = 'B';
                    }
                    else
                    {
                        beeTerritory[beeRow][beeCol] = 'B';
                    }
                }
                else
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (polinationedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinationedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinationedFlowers} flowers more");
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join("", beeTerritory[i]));
            }
        }
    }
}
