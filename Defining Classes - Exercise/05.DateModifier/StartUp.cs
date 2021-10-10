using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDay = Console.ReadLine();
            string lastDay = Console.ReadLine();
            Console.WriteLine(Math.Abs(DateModifier.DifferenceBetweenTwoDates(firstDay, lastDay)));
        }
    }
}
