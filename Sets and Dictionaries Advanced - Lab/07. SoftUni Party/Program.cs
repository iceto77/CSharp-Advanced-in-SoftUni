using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuest = new HashSet<string>();
            HashSet<string> regularGuest = new HashSet<string>();
            string input = Console.ReadLine();
            bool isPartyStarted = false;
            while (input != "END")
            {
                if (input == "PARTY")
                {
                    isPartyStarted = true;
                }
                if (isPartyStarted)
                {
                    if (input[0] > 47 && input[0] < 58)
                    {
                        vipGuest.Remove(input);
                    }
                    else
                    {
                        regularGuest.Remove(input);
                    }
                }
                else
                {
                    if (input[0] > 47 && input[0] < 58)
                    {
                        vipGuest.Add(input);
                    }
                    else
                    {
                        regularGuest.Add(input);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(vipGuest.Count + regularGuest.Count);
            foreach (var item in vipGuest)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regularGuest)
            {
                Console.WriteLine(item);
            }
        }
    }
}
