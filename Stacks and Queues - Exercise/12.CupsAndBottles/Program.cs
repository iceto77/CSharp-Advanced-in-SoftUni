using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;
            int currentCup = 0;
            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentBottle = bottles.Peek();
                if (currentCup == 0)
                {
                    currentCup = cups.Peek();
                }
                if (currentCup <= currentBottle)
                {
                    cups.Dequeue();
                    bottles.Pop();
                    wastedWater += currentBottle - currentCup;
                    currentCup = 0;
                }
                else
                {
                    currentCup -= currentBottle;
                    bottles.Pop();
                }
            }
            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups) }");
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles) }");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
