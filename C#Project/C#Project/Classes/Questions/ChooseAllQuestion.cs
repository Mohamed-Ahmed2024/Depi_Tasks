using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Questions
{
    public class ChooseAllQuestion : Question
    {
        public List<string> Options { get; set; }

        public ChooseAllQuestion() : base()
        {
            Options = new List<string>();
        }

        public ChooseAllQuestion(string header) : base(header)
        {
            Options = new List<string>();
        }

        public ChooseAllQuestion(string header, string body) : base(header, body)
        {
            Options = new List<string>();
        }

        public ChooseAllQuestion(string header, string body, int marks) : base(header, body, marks)
        {
            Options = new List<string>();
        }

        public override string Display()
        {
            var display = $"{Header}\n{Body} (Choose all that apply - {Marks} marks)\n";
            for (int i = 0; i < Options.Count; i++)
            {
                display += $"{(char)('A' + i)}. {Options[i]}\n";
            }
            return display;
        }
    }
}
