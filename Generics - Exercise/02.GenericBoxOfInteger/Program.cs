using System;

namespace GenericBoxOfInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Box<int> myBox = new Box<int>();
            for (int i = 0; i < num; i++)
            {
                myBox.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(myBox);
        }
    }
}
