using System;
using System.Linq;
using System.Text;

namespace Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split(' ');
            MyThreeuple<string, string, string> firstLine = new MyThreeuple<string, string, string>($"{inputOne[0]} {inputOne[1]}", inputOne[2],string.Join(" ", inputOne.Skip(3)));
            string[] inputTwo = Console.ReadLine().Split(' ');
            bool isDrunk = inputTwo[2] == "drunk";       
            MyThreeuple<string, int, bool> secondLine = new MyThreeuple<string, int, bool>(inputTwo[0], int.Parse(inputTwo[1]), isDrunk);
            string[] inputThree = Console.ReadLine().Split(' ');
            MyThreeuple<string, double, string> thirdLine = new MyThreeuple<string, double, string>(inputThree[0], double.Parse(inputThree[1]), inputThree[2]);
            Console.WriteLine(firstLine.ToString());
            Console.WriteLine(secondLine.ToString());
            Console.WriteLine(thirdLine.ToString());

        }
    }
}
