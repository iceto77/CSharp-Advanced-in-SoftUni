using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int>();
            foreach (var item in clothes)
            {
                clothesStack.Push(item);
            }
            int racksCount = 1;
            int curentRack = capacityOfRack;
            while (clothesStack.Count > 0)
            {
                if (clothesStack.Peek() <= curentRack)
                {
                    curentRack -= clothesStack.Pop();
                }
                else
                {
                    racksCount++;
                    curentRack = capacityOfRack;
                }
            }
            Console.WriteLine(racksCount);
        }
    }
}
