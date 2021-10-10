using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddMember(Person person)
        {
            People.Add(person);
        }
        public List<Person> GetOlderThirtyMembers()
        {
            List<Person> olderThirtyMembers = People
                    .Where(x => x.Age > 30)
                    .OrderBy(x => x.Name)
                    .ToList();

            return olderThirtyMembers;
        }

    }
}
