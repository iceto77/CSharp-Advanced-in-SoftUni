using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numberStack = new Stack<int>();
            for (int i = 0; i < command[0]; i++)
            {
                numberStack.Push(numbers[i]);
            }
            for (int i = 0; i < command[1]; i++)
            {
                if (numberStack.Count > 0)
                {
                    numberStack.Pop();
                }
            }
            int smallestElement = int.MaxValue;
            if (numberStack.Count > 0)
            {
                bool isExist = false;
                foreach (var item in numberStack)
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
