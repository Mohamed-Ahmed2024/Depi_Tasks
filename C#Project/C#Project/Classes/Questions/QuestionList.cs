using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Questions
{
    public class QuestionList : List<Question>
    {
        private string _logFileName;

        public QuestionList() : this("default_questions.txt") { }

        public QuestionList(string logFileName)
        {
            _logFileName = logFileName;
        }

        public new void Add(Question item)
        {
            // Keep default behavior
            base.Add(item);

            // Add logging functionality
            LogQuestionToFile(item);
        }

        private void LogQuestionToFile(Question question)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(_logFileName, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] Question Added: {question.ToString()}");
                    writer.WriteLine($"Type: {question.GetType().Name}");
                    writer.WriteLine($"Answers Count: {question.Answers.Count}");
                    writer.WriteLine("---");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging question: {ex.Message}");
            }
        }
    }
}
