using System;
using System.Linq;
using C_Project.Classes.Models;
using C_Project.Classes.Questions;
using C_Project.Classes.Exams;

namespace C_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create subjects
            var mathSubject = new Subject(1, "Advanced Mathematics", "MATH301", 3);
            var csSubject = new Subject(2, "Computer Science Fundamentals", "CS101", 4);

            // Create students
            var student1 = new Student(1, "Alice Johnson", "alice@email.com");
            var student2 = new Student(2, "Bob Smith", "bob@email.com");
            var student3 = new Student(3, "Carol Williams", "carol@email.com");

            // Create practice exam
            var practiceExam = new PracticeExam(1, TimeSpan.FromMinutes(30), mathSubject);

            // Create final exam
            var finalExam = new FinalExam(2, TimeSpan.FromMinutes(120), csSubject);

            // Register students for notifications
            practiceExam.RegisterStudent(student1);
            practiceExam.RegisterStudent(student2);
            finalExam.RegisterStudent(student2);
            finalExam.RegisterStudent(student3);

            // Create sample questions for practice exam
            var tfQuestion = new TrueFalseQuestion("Q1", "The derivative of x² is 2x", 5);
            tfQuestion.Answers.Add(new Answer(1, "True", true));
            tfQuestion.Answers.Add(new Answer(2, "False", false));
            practiceExam.Questions.Add(tfQuestion);

            var mcQuestion = new ChooseOneQuestion("Q2", "What is 2 + 2?", 3);
            mcQuestion.Options.AddRange(new[] { "3", "4", "5", "6" });
            mcQuestion.Answers.Add(new Answer(1, "3", false));
            mcQuestion.Answers.Add(new Answer(2, "4", true));
            mcQuestion.Answers.Add(new Answer(3, "5", false));
            mcQuestion.Answers.Add(new Answer(4, "6", false));
            practiceExam.Questions.Add(mcQuestion);

            // Create sample questions for final exam
            var maQuestion = new ChooseAllQuestion("Q1", "Which of the following are programming languages?", 10);
            maQuestion.Options.AddRange(new[] { "C#", "HTML", "Python", "CSS", "Java" });
            maQuestion.Answers.Add(new Answer(1, "C#", true));
            maQuestion.Answers.Add(new Answer(2, "HTML", false));
            maQuestion.Answers.Add(new Answer(3, "Python", true));
            maQuestion.Answers.Add(new Answer(4, "CSS", false));
            maQuestion.Answers.Add(new Answer(5, "Java", true));
            finalExam.Questions.Add(maQuestion);

            var tfQuestion2 = new TrueFalseQuestion("Q2", "Object-oriented programming supports inheritance", 5);
            tfQuestion2.Answers.Add(new Answer(1, "True", true));
            tfQuestion2.Answers.Add(new Answer(2, "False", false));
            finalExam.Questions.Add(tfQuestion2);

            // Update question counts
            practiceExam.NumberOfQuestions = practiceExam.Questions.Count;
            finalExam.NumberOfQuestions = finalExam.Questions.Count;

            // User interaction
            Console.WriteLine("Welcome to the Examination System!");
            Console.WriteLine("Available Exams:");
            Console.WriteLine("1. Practice Exam - Advanced Mathematics");
            Console.WriteLine("2. Final Exam - Computer Science Fundamentals");

            Console.Write("\nSelect exam type (1 for Practice, 2 for Final): ");
            string? choice = Console.ReadLine();

            Exam? selectedExam = null;

            switch (choice)
            {
                case "1":
                    selectedExam = practiceExam;
                    Console.WriteLine("\nYou selected: Practice Exam");
                    break;
                case "2":
                    selectedExam = finalExam;
                    Console.WriteLine("\nYou selected: Final Exam");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Defaulting to Practice Exam.");
                    selectedExam = practiceExam;
                    break;
            }

            // Demonstrate exam mode changes and notifications
            Console.WriteLine("\n=== Starting Exam Process ===");
            selectedExam.StartExam();

            // Show the exam
            selectedExam.ShowExam();

            // Finish the exam
            Console.WriteLine("\n=== Finishing Exam ===");
            selectedExam.FinishExam();

            // Demonstrate cloning
            Console.WriteLine("\n=== Demonstrating Cloning ===");
            var clonedExam = (Exam)selectedExam.Clone();
            Console.WriteLine($"Original: {selectedExam}");
            Console.WriteLine($"Cloned: {clonedExam}");

            // Demonstrate comparison
            Console.WriteLine("\n=== Demonstrating Comparison ===");
            int comparison = practiceExam.CompareTo(finalExam);
            Console.WriteLine($"Practice exam compared to final exam: {comparison}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
