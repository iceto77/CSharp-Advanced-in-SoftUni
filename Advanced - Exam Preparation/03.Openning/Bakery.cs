using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> employees;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employees = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => employees.Count();

        public void Add(Employee person)
        {
            if (!employees.Contains(person) && employees.Count < Capacity)
            {
                employees.Add(person);
            }
        }

        public bool Remove(string name)
        {
            Employee person = employees.FirstOrDefault(x => x.Name == name);
            if (employees.Contains(person))
            {
                employees.Remove(person);
                return true;
            }
            return false;
        }

        public Employee GetOldestEmployee()
        {
            return employees.OrderByDescending(x => x.Age).FirstOrDefault();
        }        
        public Employee GetEmployee(string name)
        {
            return employees.FirstOrDefault(x => x.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var item in employees)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
