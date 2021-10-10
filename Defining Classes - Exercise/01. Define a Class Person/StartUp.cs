using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Kiro";
            person.Age = 24;

            Console.WriteLine(person.Name);
        }
    }
}
