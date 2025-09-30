using System;

namespace Homework
{
    class WritingAssignment : Assingment
    {
        private string _title;

        public WritingAssignment() {}

        public WritingAssignment(
            string studentName,
            string topic,
            string title
        ) : base(studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            return $"{base.GetStudentName()} by {base.GetTopic()}\n{_title}";
        }
    }
}
