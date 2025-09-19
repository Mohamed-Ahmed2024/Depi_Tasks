using C_Project.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Classes.Events
{
    public class ExamEventArgs : EventArgs
    {
        public string ExamInfo { get; set; }
        public Subject Subject { get; set; }

        public ExamEventArgs(string examInfo, Subject subject)
        {
            ExamInfo = examInfo;
            Subject = subject;
        }
    }
}
