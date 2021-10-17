using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Box<int> myBox = new Box<int>();
            for (int i = 0; i < num; i++)
            {
                myBox.Add(int.Parse(Console.ReadLine()));
            }
            int[] swapSommand = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            myBox.SwapsTheElements(swapSommand[0], swapSommand[1]);
            Console.WriteLine(myBox);
        }
    }
}
