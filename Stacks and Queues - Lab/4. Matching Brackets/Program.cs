using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> bracketsIndex = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketsIndex.Push(i);
                }
                else if (input[i] == ')')
                {
                    if (bracketsIndex.Count > 0)
                    {
                        int startIndex = bracketsIndex.Pop();
                        int endIndex = i;
                        Console.WriteLine(input.Substring(startIndex, endIndex - startIndex +1));
                    }
                }
            }
        }
    }
}
