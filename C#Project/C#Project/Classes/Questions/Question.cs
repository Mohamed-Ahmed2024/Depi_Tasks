using System;
using C_Project.Classes.Models;

namespace C_Project.Classes.Questions
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }

        protected Question() : this("", "", 0) { }

        protected Question(string header) : this(header, "", 0) { }

        protected Question(string header, string body) : this(header, body, 0) { }

        protected Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswerList();
        }

        public abstract string Display();

        public virtual object Clone()
        {
            var cloned = (Question)this.MemberwiseClone();
            cloned.Answers = (AnswerList)Answers.Clone();
            return cloned;
        }

        public virtual int CompareTo(Question? other)  
        {
            if (other == null) return 1;
            return this.Marks.CompareTo(other.Marks);
        }

        public override string ToString()
        {
            return $"{Header}: {Body} ({Marks} marks)";
        }

        public override bool Equals(object? obj)  
        {
            if (obj is not Question other) return false;
            return Header == other.Header && Body == other.Body && Marks == other.Marks;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Header, Body, Marks);
        }
    }
}
