using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class ReflectionActivity : DrawingActivity
    {
        private List<Ponder> _ponders = new List<Ponder>();

        public ReflectionActivity(
            string title,
            string description
        ) : base(title, description) { }

        public ReflectionActivity(
            string title,
            string description,
            List<string> messages,
            List<Ponder> ponders
        ) : base(title, description)
        {
            foreach (string message in messages)
            {
                SetMessage(message);
            }

            foreach (Ponder ponder in ponders)
            {
                SetPonder(ponder);
            }
        }

        public void SetPonder(Ponder ponder) => _ponders.Add(ponder);

        public Ponder DrawingPonder()
        {
            Random random = new Random();

            List<Ponder> unusedPonders = _ponders.FindAll(p => !p.IsUsed());

            if (unusedPonders.Count > 0)
            {
                int index = random.Next(unusedPonders.Count);
                Ponder message = unusedPonders[index];
                message.MarkAsUsed();
                return message;
            }
            return null;
        }
        
        private void DisplayPonders()
        {
            DateTime startedAt = DateTime.Now;
            DateTime endedAt = startedAt.AddSeconds(GetDuration());

            Console.WriteLine("");

            while (DateTime.Now < endedAt)
            {
                Ponder ponder = DrawingPonder();
                if (ponder != null)
                {
                    ShowSpinning(message: $"> {ponder.GetMessage()} ", seconds: 5);
                    Console.WriteLine("");
                }
                else
                {
                    break;
                }
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
