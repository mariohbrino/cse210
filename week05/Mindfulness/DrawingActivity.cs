using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class DrawingActivity(
        string title,
        string description
    ) : Activity(title, description)
    {
        private List<string> _messages = [];

        public List<string> GetMessages() => _messages;

        public void SetMessage(string message) => _messages.Add(message);

        public string DrawingMessage()
        {
            Random random = new Random();
            if (_messages.Count > 0)
            {
                int index = random.Next(_messages.Count);
                string message = _messages[index];
                return message;
            }
            return "No message found.";
        }

        public void DisplayRandomMessage(string prompt)
        {
            string message = DrawingMessage();
            Console.WriteLine("");
            Console.WriteLine($"{prompt}");
            Console.WriteLine("");
            Console.WriteLine($" --- {message} ---");
            Console.WriteLine("");
        }
    }
}
