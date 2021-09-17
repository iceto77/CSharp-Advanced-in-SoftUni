using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<String> Supermarket = new Queue<string>();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    int endIndex = Supermarket.Count;
                    for (int i = 0; i < endIndex; i++)
                    {
                        Console.WriteLine(Supermarket.Dequeue());
                    }
                }
                else
                {
                    Supermarket.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{Supermarket.Count} people remaining.");
        }
    }
}
