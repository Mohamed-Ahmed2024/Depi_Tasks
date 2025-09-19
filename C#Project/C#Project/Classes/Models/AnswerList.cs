using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Models
{
    public class AnswerList : List<Answer>, ICloneable
    {
        public object Clone()
        {
            var cloned = new AnswerList();
            foreach (var answer in this)
            {
                cloned.Add((Answer)answer.Clone());
            }
            return cloned;
        }
    }
}
