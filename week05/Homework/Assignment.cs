using System;

namespace Homework
{
    class Assingment
    {
        private string _studentName;
        private string _topic;

        public Assingment () {}

        public Assingment(
            string studentName,
            string topic
        )
        {
            _studentName = studentName;
            _topic = topic;
        }

        public string GetStudentName()
        {
            return _studentName;
        }

        public string GetTopic()
        {
            return _topic;
        }

        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}