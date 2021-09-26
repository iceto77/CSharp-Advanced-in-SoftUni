using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < num; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
