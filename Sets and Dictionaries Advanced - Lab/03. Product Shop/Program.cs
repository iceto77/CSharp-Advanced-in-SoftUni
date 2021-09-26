using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> foodShops = new SortedDictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                string[] information = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = information[0];
                string product = information[1];
                double price = double.Parse(information[2]);
                if (!foodShops.ContainsKey(shop))
                {
                    foodShops.Add(shop, new Dictionary<string, double>());
                }
                foodShops[shop].Add(product, price);



                input = Console.ReadLine();
            }
            foreach (var shops in foodShops)
            {
                Console.WriteLine($"{shops.Key}->");
                foreach (var item in shops.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
