using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Family myFamily = new Family();
            int membersNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < membersNumber; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                Person curentMember = new Person(name, age);
                myFamily.AddMember(curentMember);
            }
            List<Person> olderThirtyMembers = myFamily.GetOlderThirtyMembers();
            foreach (var item in olderThirtyMembers)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
