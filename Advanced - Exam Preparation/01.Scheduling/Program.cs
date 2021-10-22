using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> taskValue = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse)); //zadacha
            Queue<int> threadValue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));  //nishka
            int targetTask = int.Parse(Console.ReadLine());
            while (taskValue.Count > 0 && threadValue.Count > 0)
            {
                int curentTask = taskValue.Peek();
                int curentThread = threadValue.Peek();
                if (curentTask == targetTask)
                {
                    Console.WriteLine($"Thread with value {curentThread} killed task {targetTask}");
                    break;
                }
                if (curentThread >= curentTask)
                {
                    threadValue.Dequeue();
                    taskValue.Pop();
                }
                else
                {
                    threadValue.Dequeue();
                }

            }
            Console.WriteLine(string.Join(" ", threadValue));

        }
    }
}
