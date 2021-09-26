using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<int, int> numberCollection = new Dictionary<int, int>();
            for (int i = 0; i < num; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!numberCollection.ContainsKey(input))
                {
                    numberCollection.Add(input, 0);
                }
                numberCollection[input]++;
            }
            foreach (var item in numberCollection)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
