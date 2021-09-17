using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbersQueue = new Queue<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbersQueue.Enqueue(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(", ", evenNumbersQueue));
        }
    }
}
