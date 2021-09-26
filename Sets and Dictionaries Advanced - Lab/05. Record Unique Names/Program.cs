using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
