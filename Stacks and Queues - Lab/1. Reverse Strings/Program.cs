using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverceString = new Stack<char>();
            foreach (char ch in input)
            {
                reverceString.Push(ch);
            }
            while (reverceString.Count > 0)
            {
                Console.Write(reverceString.Pop());
            }
        }
    }
}
