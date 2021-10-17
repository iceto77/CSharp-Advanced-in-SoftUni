using System;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Box<double> myBox = new Box<double>();
            for (int i = 0; i < num; i++)
            {
                myBox.Add(double.Parse(Console.ReadLine()));
            }
            double target = double.Parse(Console.ReadLine());
            Console.WriteLine(myBox.CountOfGreaterElements(target));
        }
    }
}
