using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            int wreaths = 0;
            int savedFlowers = 0;
            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currenLilies = lilies.Peek();
                int currenRoses = roses.Peek();
                if (currenLilies + currenRoses == 15)
                {
                    lilies.Pop();
                    roses.Dequeue();
                    wreaths++;
                }
                else if (currenLilies + currenRoses > 15)
                {                    
                    lilies.Push(lilies.Pop() - 2);
                }
                else
                {
                    savedFlowers += lilies.Pop() + roses.Dequeue();
                }

            }
            if (savedFlowers >= 15)
            {
                wreaths += savedFlowers / 15;
                savedFlowers = savedFlowers % 15;
            }
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
