using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class ReflectionActivity : DrawingActivity
    {
        private List<string> _ponders = [];

        public ReflectionActivity(
            string title,
            string description
        ) : base(title, description) { }

        public ReflectionActivity(
            string title,
            string description,
            List<string> messages,
            List<string> ponders
        ) : base(title, description)
        {
            foreach (string message in messages)
            {
                SetMessage(message);
            }

            foreach (string ponder in ponders)
            {
                SetPonder(ponder);
            }
        }

        public void SetPonder(string ponder) => _ponders.Add(ponder);

        public string DrawingPonder()
        {
            Random random = new Random();
            if (_ponders.Count > 0)
            {
                int index = random.Next(_ponders.Count);
                string message = _ponders[index];
                return message;
            }
            return "No ponder found.";
        }
        
        private void DisplayPonders()
        {
            DateTime startedAt = DateTime.Now;
            DateTime endedAt = startedAt.AddSeconds(GetDuration());

            Console.WriteLine("");

            while (DateTime.Now < endedAt)
            {
                string ponder = DrawingPonder();
                ShowSpinning(message: $"> {ponder} ", seconds: 5);
                Console.WriteLine("");
            }
        }

        public void PonderMessage()
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            ShowCountdown(message: "You may begin in: ", seconds: 5);
            DisplayPonders();
        }

        public override void StartActivity()
        {
            base.StartActivity();
            DisplayRandomMessage(prompt: "Consider the following prompt:");
            PauseUntilEnter();
            PonderMessage();
            DisplayEndMessage(message: $"You have completed another {GetDuration()} second(s) of the Reflecting Activity.\n");
        }
    }
}
