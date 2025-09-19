using C_Project.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Exams
{
    public class PracticeExam : Exam
    {
        public PracticeExam() : base() { }

        public PracticeExam(int examId) : base(examId) { }

        public PracticeExam(int examId, TimeSpan duration, Subject subject) : base(examId, duration, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine($"\n=== PRACTICE EXAM ===");
            Console.WriteLine($"Subject: {ExamSubject.SubjectName}");
            Console.WriteLine($"Duration: {Duration.TotalMinutes} minutes");
            Console.WriteLine($"Questions: {Questions.Count}");
            Console.WriteLine("===================\n");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(Questions[i].Display());

                // Show correct answers after displaying question (Practice Exam feature)
                Console.WriteLine("Correct Answer(s):");
                foreach (var answer in Questions[i].Answers.Where(a => a.IsCorrect))
                {
                    Console.WriteLine($"✓ {answer.AnswerText}");
                }
                Console.WriteLine();
            }
        }
    }
}
