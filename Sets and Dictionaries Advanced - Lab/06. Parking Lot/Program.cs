using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parkingLot = new HashSet<string>();
            while (input != "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "IN")
                {
                    parkingLot.Add(command[1]);
                }
                else if (command[0] == "OUT")
                {
                    parkingLot.Remove(command[1]);
                }
                input = Console.ReadLine();
            }
            if (parkingLot.Count > 0)
            {
                foreach (var item in parkingLot)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
