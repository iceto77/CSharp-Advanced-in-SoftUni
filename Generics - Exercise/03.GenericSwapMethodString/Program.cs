using System;
using System.Linq;

namespace GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Box<string> myBox = new Box<string>();
            for (int i = 0; i < num; i++)
            {
                myBox.Add(Console.ReadLine());
            }
            int[] swapSommand = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            myBox.SwapsTheElements(swapSommand[0], swapSommand[1]);
            Console.WriteLine(myBox);
        }
    }
}
