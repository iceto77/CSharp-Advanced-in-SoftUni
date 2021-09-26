using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> mapOfEart = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < num; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = info[0];
                string country = info[1];
                string city = info[2];
                if (!mapOfEart.ContainsKey(continent))
                {
                    mapOfEart.Add(info[0], new Dictionary<string, List<string>>());
                }
                if (!mapOfEart[continent].ContainsKey(country))
                {
                    mapOfEart[continent].Add(country, new List<string>());
                }
                mapOfEart[continent][country].Add(city);
            }
            foreach (var item in mapOfEart)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var state in item.Value)
                {
                    Console.WriteLine($"{state.Key} -> {string.Join(", ", state.Value)}");
                }
            }
        }
    }
}
