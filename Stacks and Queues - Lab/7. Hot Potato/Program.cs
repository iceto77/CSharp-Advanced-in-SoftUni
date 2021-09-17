using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<String> hotPotato = new Queue<string>();
            string[] player = input.Split();
            foreach (var name in player)
            {
                hotPotato.Enqueue(name);
            }
            int tossNumber = int.Parse(Console.ReadLine());
            while (hotPotato.Count > 1)
            {
                for (int i = 1; i < tossNumber; i++)
                {
                    hotPotato.Enqueue(hotPotato.Dequeue());                    
                }
                Console.WriteLine($"Removed {hotPotato.Dequeue()}");
            }
            Console.WriteLine($"Last is {hotPotato.Peek()}");
        }
    }
}
