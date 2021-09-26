using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!studentsGrades.ContainsKey(input[0]))
                {
                    studentsGrades.Add(input[0], new List<decimal>());
                }
                decimal grade = decimal.Parse(input[1]);
                if (grade >= 2 && grade <= 6)
                {
                    studentsGrades[input[0]].Add(grade);
                }
            }
            foreach (var item in studentsGrades)
            {
                decimal averageGrade = item.Value.Average();
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {averageGrade:f2})");

            }

        }
    }
}
