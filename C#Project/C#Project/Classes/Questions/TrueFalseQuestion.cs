using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Questions
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion() : base() { }

        public TrueFalseQuestion(string header) : base(header) { }

        public TrueFalseQuestion(string header, string body) : base(header, body) { }

        public TrueFalseQuestion(string header, string body, int marks) : base(header, body, marks) { }

        public override string Display()
        {
            return $"{Header}\n{Body}\nTrue or False? ({Marks} marks)";
        }
    }
}
