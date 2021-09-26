using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicalElements = new SortedSet<string>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    chemicalElements.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}
