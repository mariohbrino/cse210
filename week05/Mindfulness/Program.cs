using System;
using System.Collections.Generic;

// Enhancements:
// 1. Menu class to handle user choices and navigation.
// 2. Choice class to represent each menu option.
// 3. Improved user prompts and messages for better engagement.
// 4. Ponder class to encapsulate reflection questions.
//  - Make sure no random prompts/questions are selected until
//    they have all been used at least once in that session.

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
                    new Ponder("Why was this experience meaningful to you?"),
                    new Ponder("Have you ever done anything like this before?"),
                    new Ponder("How did you get started?"),
                    new Ponder("How did you feel when it was complete?"),
                    new Ponder("What made this time different than other times when you were not as successful?"),
                    new Ponder("What is your favorite thing about this experience?"),
                    new Ponder("What could you learn from this experience that applies to other situations?"),
                    new Ponder("What did you learn about yourself through this experience?"),
                    new Ponder("How can you keep this experience in mind in the future?")
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
