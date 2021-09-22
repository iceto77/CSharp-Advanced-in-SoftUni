using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsNumber = int.Parse(Console.ReadLine());
            Queue<int[]> pumpsCircle = new Queue<int[]>();
            for (int i = 0; i < pumpsNumber; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumpsCircle.Enqueue(input);
            }
            int smallestIndex = 0;
            while (true)
            {
                int petrolTank = 0;
                foreach (var item in pumpsCircle)
                {
                    petrolTank += item[0];
                    petrolTank -= item[1];
                    if (petrolTank < 0)
                    {
                        pumpsCircle.Enqueue(pumpsCircle.Dequeue());
                        smallestIndex++;
                        break;
                    }
                }
                if (petrolTank >= 0)
                {
                    Console.WriteLine(smallestIndex);
                    break;
                }
            }
        }
    }
}
