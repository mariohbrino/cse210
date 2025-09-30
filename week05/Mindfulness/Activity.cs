using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class Activity(string title, string description)
    {
        private string _title = title;
        private string _description = description;
        private int _duration;
        private List<string> _animationList = ["|", "/", "-", "\\"];

        public string GetTitle() => _title;
        public string GetDescription() => _description;
        public int GetDuration() => _duration;

        public void DisplayStartMessage()
        {
            Console.WriteLine(_title);
            Console.WriteLine("");
            Console.WriteLine(_description);
            Console.WriteLine("");
        }

        public void DisplayEndMessage(string message)
        {
            Console.WriteLine("");
            Console.WriteLine("Well done!!!");
            Console.WriteLine("");
            ShowSpinning(message: message, seconds: 5);
            Console.WriteLine("");
        }

        public void PromptInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int response = int.Parse(Console.ReadLine());
                    _duration = response;
                    Console.Clear();
                    break;
                }
                catch (FormatException exception)
                {
                    Console.WriteLine($"Invalid input. Please enter a valid number. [ERROR] => {exception.Message}\n");
                }
            }
        }

        public void ShowSpinning(string message, int? seconds = null)
        {
            DateTime startedAt = DateTime.Now;
            DateTime endedAt = startedAt.AddSeconds(seconds.HasValue ? seconds.Value : _duration);

            Console.Write(message);

            int index = 0;

            while (DateTime.Now < endedAt)
            {
                string animation = _animationList[index];
                Console.Write(animation);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                index++;

                if (index >= _animationList.Count)
                {
                    index = 0;
                }
            }
        }

        public static void ShowCountdown(string message, int seconds)
        {
            Console.Write($"{message}");
            
            DateTime startedAt = DateTime.Now;
            DateTime endedAt = startedAt.AddSeconds(seconds);

            while (DateTime.Now < endedAt)
            {
                Console.Write(seconds);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                seconds--;
            }
        }

        public virtual void StartActivity()
        {
            DisplayStartMessage();
            PromptInput();
            ShowSpinning(seconds: 5, message: "Get ready...\n");
        }
    }
}
