using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numberQueue = new Queue<int>();
            for (int i = 0; i < command[0]; i++)
            {
                numberQueue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < command[1]; i++)
            {
                if (numberQueue.Count > 0)
                {
                    numberQueue.Dequeue();
                }
            }
            int smallestElement = int.MaxValue;
            if (numberQueue.Count > 0)
            {
                bool isExist = false;
                foreach (var item in numberQueue)
                {
                    if (item == command[2])
                    {
                        isExist = true;
                    }
                    else
                    {
                        if (item < smallestElement)
                        {
                            smallestElement = item;
                        }
                    }
                }
                if (isExist)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(smallestElement);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
