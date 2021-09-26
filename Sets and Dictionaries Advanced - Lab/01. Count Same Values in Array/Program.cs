using System;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> MyDict = new Dictionary<string, int>();
            string[] incomingData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in incomingData)
            {
                if (!MyDict.ContainsKey(item))
                {
                    MyDict.Add(item, 0);
                }
                MyDict[item]++;
            }
            foreach (var item in MyDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
