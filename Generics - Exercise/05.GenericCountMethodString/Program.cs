using System;

namespace GenericCountMethodString
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
            string target = Console.ReadLine();
            Console.WriteLine(myBox.CountOfGreaterElements(target));
        }
    }
}
