using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gardenDimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] garden = new int[gardenDimension[0]][];
            for (int i = 0; i < gardenDimension[0]; i++)
            {
                int[] temp = new int[gardenDimension[1]];
                for (int j = 0; j < gardenDimension[1]; j++)
                {
                    temp[j] = 0;
                }
                garden[i] = temp;
            }
            Dictionary<int, int> flowers = new Dictionary<int, int>();
            string input = Console.ReadLine();
            while (input != "Bloom Bloom Plow")
            {
                int[] flower = input.Split().Select(int.Parse).ToArray();
                int row = flower[0];
                int col = flower[1];
                if (row >= 0 && row < gardenDimension[0] && col >= 0 && col < gardenDimension[1])
                {
                    flowers.Add(row, col);
                }
                else
                {
                    Console.WriteLine($"Invalid coordinates.");
                }
                input = Console.ReadLine();
            }
            while (flowers.Count > 0)
            {
                int row = flowers.First().Key;
                int col = flowers.First().Value;
                for (int i = 0; i < gardenDimension[0]; i++)
                {
                    garden[row][i]++;
                }
                for (int i = 0; i < gardenDimension[1]; i++)
                {
                    garden[i][col]++;
                }
                garden[row][col]--;
                flowers.Remove(row);
            }
            for (int i = 0; i < gardenDimension[0]; i++)
            {
                for (int j = 0; j < gardenDimension[1]; j++)
                {
                    Console.Write($"{garden[i][j]} ");                    
                }
                Console.WriteLine();
            }
        }
    }
}
