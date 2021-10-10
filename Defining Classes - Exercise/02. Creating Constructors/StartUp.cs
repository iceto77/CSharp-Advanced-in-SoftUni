using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            person = new Person(23);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            person = new Person("Ico", 44);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
