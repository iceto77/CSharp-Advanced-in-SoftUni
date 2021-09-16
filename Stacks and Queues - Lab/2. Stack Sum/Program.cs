using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            
            string[] numbers = input.Split().ToArray();            
            Stack<int> integerStack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                integerStack.Push(int.Parse(numbers[i]));
            }
            input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                switch (command[0])
                {
                    case "add":
                        integerStack.Push(int.Parse(command[1]));
                        integerStack.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        int targetNum = int.Parse(command[1]);
                        if (targetNum <= integerStack.Count)
                        {
                            for (int i = 0; i < targetNum; i++)
                            {
                                integerStack.Pop();
                            }
                        }
                        break;
                }
                input = Console.ReadLine().ToLower();
            }
            int sum = 0;
            foreach (int item in integerStack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
