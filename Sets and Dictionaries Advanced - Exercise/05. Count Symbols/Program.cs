using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> textToAnalyze = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!textToAnalyze.ContainsKey(input[i]))
                {
                    textToAnalyze.Add(input[i], 0);
                }
                textToAnalyze[input[i]]++;
            }
            foreach (var item in textToAnalyze)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
