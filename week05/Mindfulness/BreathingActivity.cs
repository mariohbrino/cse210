using System;

namespace Mindfulness
{
    class BreathingActivity(
        string title,
        string description
    ) : Activity(title, description)
    {
        private void DisplayBreathMessages()
        {
            DateTime startedAt = DateTime.Now;
            DateTime endedAt = startedAt.AddSeconds(GetDuration());

            Console.WriteLine("");

            while (DateTime.Now < endedAt)
            {
                ShowCountdown(message: $"> Breathe in... ", seconds: 4);
                Console.WriteLine("");
                ShowCountdown(message: $"> Breathe out... ", seconds: 6);
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        public override void StartActivity()
        {
            base.StartActivity();
            DisplayBreathMessages();
            DisplayEndMessage(message: $"You have completed another {GetDuration()} second(s) of the Breathing Activity.\n");
        }
    }
}
