using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class ListingActivity : DrawingActivity
    {
        private List<string> responses = [];

        public ListingActivity(
            string title,
            string description,
            List<string> messages
        ) : base(title, description)
        {
            foreach (string message in messages)
            {
                SetMessage(message);
            }
        }

        public void RecordResponses()
        {
            DateTime startedAt = DateTime.Now;
            DateTime endedAt = startedAt.AddSeconds(GetDuration());

            Console.WriteLine("");

            while (DateTime.Now < endedAt)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                responses.Add(response);
            }

            Console.WriteLine("");
            Console.WriteLine($"You listed {responses.Count} item(s).");
        }

        public override void StartActivity()
        {
            base.StartActivity();
            DisplayRandomMessage(prompt: "List as many responses you can to the following prompt:");
            ShowCountdown(message: "You may begin in: ", seconds: 5);
            RecordResponses();
            DisplayEndMessage(message: $"You have completed another {GetDuration()} second(s) of the Listing Activity.\n");
        }
    }
}
