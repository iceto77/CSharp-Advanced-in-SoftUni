using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>();
            foreach (var item in orders)
            {
                ordersQueue.Enqueue(item);
            }
            int maxOrder = int.MinValue;
            foreach (var item in orders)
            {
                if (item > maxOrder)
                {
                    maxOrder = item;
                }
            }
            while (quantityOfFood > 0)
            {
                if (ordersQueue.Peek() <= quantityOfFood)
                {
                    quantityOfFood -= ordersQueue.Dequeue();
                }
                else
                {
                    break;
                }
                if (ordersQueue.Count < 1)
                {
                    break;
                }
            }
            Console.WriteLine(maxOrder);
            if (ordersQueue.Count > 0)
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", ordersQueue));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
