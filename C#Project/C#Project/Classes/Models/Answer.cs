using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Models
{

        public class Answer : ICloneable
        {
            public int AnswerId { get; set; }
            public string AnswerText { get; set; }
            public bool IsCorrect { get; set; }

            public Answer() : this(0, "", false) { }

            public Answer(int id) : this(id, "", false) { }

            public Answer(int id, string text) : this(id, text, false) { }

            public Answer(int id, string text, bool isCorrect)
            {
                AnswerId = id;
                AnswerText = text;
                IsCorrect = isCorrect;
            }

            public object Clone()
            {
                return new Answer(AnswerId, AnswerText, IsCorrect);
            }

            public override string ToString()
            {
                return $"Answer {AnswerId}: {AnswerText} (Correct: {IsCorrect})";
            }
        }
}
