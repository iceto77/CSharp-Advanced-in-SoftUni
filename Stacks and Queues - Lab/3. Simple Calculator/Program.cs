using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> inputData = new Stack<string>();
            foreach (var item in input)
            {
                inputData.Push(item);
            }
            Stack<string> reverceData = new Stack<string>();
            foreach (var data in inputData)
            {
                reverceData.Push(data);
            }
            int sum = 0;
            char action = '+';
            while (reverceData.Count > 0)
            {
                if (reverceData.Peek() == '-'.ToString())
                {
                    action = '-';
                    reverceData.Pop();
                }
                else if (reverceData.Peek() == '+'.ToString())
                {
                    action = '+';
                    reverceData.Pop();
                }
                else
                {
                    if (action == '+')
                    {
                        sum += int.Parse(reverceData.Pop());
                    }
                    else
                    {
                        sum -= int.Parse(reverceData.Pop());
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
