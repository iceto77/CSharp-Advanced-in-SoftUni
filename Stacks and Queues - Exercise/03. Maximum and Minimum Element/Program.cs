using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lineNums = int.Parse(input);
            Stack<int> elements = new Stack<int>();
            for (int i = 0; i < lineNums; i++)
            {
                input = Console.ReadLine();
                if (input =="2")
                {
                    if (elements.Count > 0)
                    {
                        elements.Pop();
                    }
                }
                else if (input == "3")
                {
                    int maxElement = int.MinValue;
                    foreach (var item in elements)
                    {
                        if (maxElement < item)
                        {
                            maxElement = item;
                        }
                    }
                    Console.WriteLine(maxElement);
                }
                else if (input == "4")
                {
                    int minElement = int.MaxValue;
                    foreach (var item in elements)
                    {
                        if (minElement > item)
                        {
                            minElement = item;
                        }
                    }
                    Console.WriteLine(minElement);
                }
                else
                {
                    int[] command = input.Split().Select(int.Parse).ToArray();
                    if (command[0] == 1)
                    {
                        elements.Push(command[1]);
                    }
                }

            }
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
