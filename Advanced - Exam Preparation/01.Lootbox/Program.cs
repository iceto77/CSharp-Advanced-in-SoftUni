using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootbox = new Queue<int>();
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                firstLootbox.Enqueue(input[i]);
            }
            Stack<int> secondLootbox = new Stack<int>();
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                secondLootbox.Push(input[i]);
            }
            int sumOfClaimedItems = 0;
            while (firstLootbox.Count > 0 && secondLootbox.Count > 0)
            {
                if ((firstLootbox.Peek() + secondLootbox.Peek()) % 2 == 0)
                {
                    sumOfClaimedItems += firstLootbox.Dequeue() + secondLootbox.Pop();
                }
                else
                {
                    firstLootbox.Enqueue(secondLootbox.Pop());
                }

            }
            if (firstLootbox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (secondLootbox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (sumOfClaimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumOfClaimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumOfClaimedItems}");
            }
        }
    }
}
