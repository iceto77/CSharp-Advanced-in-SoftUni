using System;

namespace Tuples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split(' ');
            MyTuple<string, string> firstLine = new MyTuple<string, string>($"{inputOne[0]} {inputOne[1]}", inputOne[2]);
            string[] inputTwo = Console.ReadLine().Split(' ');
            MyTuple<string, int> secondLine = new MyTuple<string, int>(inputTwo[0], int.Parse(inputTwo[1]));
            string[] inputThree = Console.ReadLine().Split(' ');
            MyTuple<int, double> thirdLine = new MyTuple<int, double>(int.Parse(inputThree[0]), double.Parse(inputThree[1]));
            Console.WriteLine(firstLine.ToString());
            Console.WriteLine(secondLine.ToString());
            Console.WriteLine(thirdLine.ToString());


        }
    }
}
