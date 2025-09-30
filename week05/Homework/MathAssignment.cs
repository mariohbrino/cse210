using System;

namespace Homework
{
    class MathAssignment : Assingment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment() {}

        public MathAssignment(
            string studentName,
            string topic,
            string textBookSection,
            string problem
        ) : base(studentName, topic)
        {
            _textbookSection = textBookSection;
            _problems = problem;
        }

        public string GetHomeworkList()
        {
            return $"{base.GetStudentName()} - {base.GetTopic()}\nSection {_textbookSection} Problem {_problems}";
        }
    }
}
