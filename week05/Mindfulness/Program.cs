using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            BreathingActivity breathing = new BreathingActivity(
                title: "Welcome to the Breathing Activity.",
                description: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
            );

            ReflectionActivity reflectionActivity = new ReflectionActivity(
                title: "Welcome to the Reflection Activity",
                description: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                messages:
                [
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                ],
                ponders:
                [
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                ]
            );

            ListingActivity listingActivity = new ListingActivity(
                title: "Welcome to the Listing Activity",
                description: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                messages:
                [
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                ]
            );

            Menu menu = new Menu();
            menu.SetMenuList(
            [
                new Choice(
                    index: 1,
                    name: "Start breathing activity",
                    callback: () => breathing.StartActivity()
                ),
                new Choice(
                    index: 2,
                    name: "Start reflecting activity",
                    callback: () => reflectionActivity.StartActivity()
                ),
                new Choice(
                    index: 3,
                    name: "Start listing activity",
                    callback: () => listingActivity.StartActivity()
                ),
                new Choice(
                    index: 4,
                    name: "Quit",
                    quit: true,
                    callback: () => Console.WriteLine("Bye, see you again.")
                )
            ]);
            menu.DisplayMenu();
        }
    }
}
