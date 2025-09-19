using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public Student() : this(0, "", "") { }

        public Student(int id) : this(id, "", "") { }

        public Student(int id, string name) : this(id, name, "") { }

        public Student(int id, string name, string email)
        {
            StudentId = id;
            StudentName = name;
            Email = email;
        }

        public void OnExamNotification(string examInfo)
        {
            Console.WriteLine($"Notification for {StudentName}: {examInfo}");
        }

        public override string ToString()
        {
            return $"Student {StudentId}: {StudentName} ({Email})";
        }
    }
}
