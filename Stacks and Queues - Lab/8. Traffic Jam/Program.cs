using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int greenLightCarsCapacity = int.Parse(input);
            Queue<String> trafficJam = new Queue<string>();
            input = Console.ReadLine();
            int carsCount = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < greenLightCarsCapacity; i++)
                    {
                        if (trafficJam.Count > 0)
                        {
                            Console.WriteLine($"{trafficJam.Dequeue()} passed!");
                            carsCount++;
                        }
                    }
                }
                else
                {
                    trafficJam.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{carsCount} cars passed the crossroads.");
        }
    }
}
