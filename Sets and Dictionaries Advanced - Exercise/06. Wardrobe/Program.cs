using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < num; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                string[] clothes = data[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                string color = data[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }
            string[] target = Console.ReadLine().Split();
            string targetColor = target[0];
            string targetClothes = target[1];
            bool isFoundTargetColor = false;
            bool isFoundTargetClothes = false;
            foreach (var item in wardrobe)
            {
                if (item.Key == targetColor)
                {
                    isFoundTargetColor = true;
                }
                else
                {
                    isFoundTargetColor = false;
                }
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var wear in item.Value)
                {
                    if (wear.Key == targetClothes)
                    {
                        isFoundTargetClothes = true;
                    }
                    else
                    {
                        isFoundTargetClothes = false;
                    }
                    if (isFoundTargetColor && isFoundTargetClothes)
                    {
                        Console.WriteLine($"* {wear.Key} - {wear.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {wear.Key} - {wear.Value}");
                    }
                }
            }
        }
    }
}
