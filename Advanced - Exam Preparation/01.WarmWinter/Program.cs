using System;
using System.Collections.Generic;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>();
            Queue<int> scarfs = new Queue<int>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                hats.Push(int.Parse(input[i]));
            }
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                scarfs.Enqueue(int.Parse(input[i]));
            }
            List<int> setHatScraf = new List<int>();
            int maxPriceSet = int.MinValue;
            while (hats.Count > 0 && scarfs.Count > 0)
            {
                if (hats.Peek() > scarfs.Peek())
                {
                    if (maxPriceSet < hats.Peek() + scarfs.Peek())
                    {
                        maxPriceSet = hats.Peek() + scarfs.Peek();
                    }
                    setHatScraf.Add(hats.Pop() + scarfs.Dequeue());
                }
                else if (scarfs.Peek() > hats.Peek())
                {
                    hats.Pop();
                    continue;
                }
                else
                {
                    scarfs.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
            }
            Console.WriteLine($"The most expensive set is: {maxPriceSet}");
            Console.WriteLine(string.Join(" ", setHatScraf));
        }
    }
}
