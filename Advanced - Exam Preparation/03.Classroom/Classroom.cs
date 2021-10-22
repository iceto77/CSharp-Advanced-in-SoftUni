using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count => students.Count();

        public string RegisterStudent(Student student)
        {
            if (!students.Contains(student) && students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return $"No seats in the classroom";
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (students.Contains(student))
            {
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
            }
            return "Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            List<Student> currentStudents = students.FindAll(x => x.Subject == subject);
            StringBuilder sb = new StringBuilder();
            if (currentStudents.Count > 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");
                foreach (var item in currentStudents)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }
            }
            else
            {
                sb.AppendLine("No students enrolled for the subject");
            }
            return sb.ToString().TrimEnd();
        }
        public int GetStudentsCount()
        {
            return students.Count();
        }
        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
