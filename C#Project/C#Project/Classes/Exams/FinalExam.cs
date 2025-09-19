using C_Project.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam() : base() { }

        public FinalExam(int examId) : base(examId) { }

        public FinalExam(int examId, TimeSpan duration, Subject subject) : base(examId, duration, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine($"\n=== FINAL EXAM ===");
            Console.WriteLine($"Subject: {ExamSubject.SubjectName}");
            Console.WriteLine($"Duration: {Duration.TotalMinutes} minutes");
            Console.WriteLine($"Questions: {Questions.Count}");
            Console.WriteLine("==================\n");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(Questions[i].Display());
                Console.WriteLine(); // No answers shown in final exam
            }
        }
    }
}
