using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int CreditHours { get; set; }

        public Subject() : this(0, "", "", 0) { }

        public Subject(int id) : this(id, "", "", 0) { }

        public Subject(int id, string name) : this(id, name, "", 0) { }

        public Subject(int id, string name, string code, int creditHours)
        {
            SubjectId = id;
            SubjectName = name;
            SubjectCode = code;
            CreditHours = creditHours;
        }

        public override string ToString()
        {
            return $"{SubjectCode}: {SubjectName} ({CreditHours} credit hours)";
        }
    }
}
