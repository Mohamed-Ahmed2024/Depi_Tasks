using System;
using System.Collections.Generic;
using C_Project.Classes.Models;
using C_Project.Classes.Questions;
using C_Project.Classes.Events;
using C_Project.Classes.Enums;

namespace C_Project.Classes.Exams
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int ExamId { get; set; }
        public TimeSpan Duration { get; set; }
        public int NumberOfQuestions { get; set; }
        public QuestionList Questions { get; set; }
        public Dictionary<Question, Answer> QuestionAnswerDictionary { get; set; }
        public Subject ExamSubject { get; set; }
        public ExamMode Mode { get; set; }
        public List<Student> RegisteredStudents { get; set; }

       
        public event ExamNotificationHandler? ExamModeChanged;


        protected Exam() : this(0, TimeSpan.FromMinutes(60), new Subject()) { }

        protected Exam(int examId) : this(examId, TimeSpan.FromMinutes(60), new Subject()) { }

        protected Exam(int examId, TimeSpan duration, Subject subject)
        {
            ExamId = examId;
            Duration = duration;
            ExamSubject = subject;
            Questions = new QuestionList($"exam_{examId}_questions.txt");
            QuestionAnswerDictionary = new Dictionary<Question, Answer>();
            Mode = ExamMode.Queued;
            RegisteredStudents = new List<Student>();
            NumberOfQuestions = 0;
        }

        public abstract void ShowExam();

        public virtual void StartExam()
        {
            Mode = ExamMode.Starting;
            OnExamModeChanged($"Exam {ExamId} for {ExamSubject.SubjectName} has started!");
        }

        public virtual void FinishExam()
        {
            Mode = ExamMode.Finished;
            OnExamModeChanged($"Exam {ExamId} for {ExamSubject.SubjectName} has finished!");
        }

        protected virtual void OnExamModeChanged(string message)
        {
            ExamModeChanged?.Invoke(this, new ExamEventArgs(message, ExamSubject));
        }

        public void RegisterStudent(Student student)
        {
            RegisteredStudents.Add(student);
            ExamModeChanged += (sender, e) => student.OnExamNotification(e.ExamInfo);
        }

        public virtual object Clone()
        {
            var cloned = (Exam)this.MemberwiseClone();
            cloned.Questions = new QuestionList();
            cloned.QuestionAnswerDictionary = new Dictionary<Question, Answer>(QuestionAnswerDictionary);
            cloned.RegisteredStudents = new List<Student>(RegisteredStudents);
            return cloned;
        }

        public virtual int CompareTo(Exam? other)  
        {
            if (other == null) return 1;
            return this.ExamId.CompareTo(other.ExamId);
        }

        public override string ToString()
        {
            return $"Exam {ExamId}: {ExamSubject.SubjectName} - {Duration.TotalMinutes} minutes ({NumberOfQuestions} questions)";
        }

        public override bool Equals(object? obj)  // nullable fix
        {
            if (obj is not Exam other) return false;
            return ExamId == other.ExamId;
        }

        public override int GetHashCode()
        {
            return ExamId.GetHashCode();
        }
    }
}
