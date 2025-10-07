using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EternalQuest
{
    class GoalManager
    {
        private List<Goal> _goals = [];
        private int _score = 0;
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.Never
        };

        public void Start()
        {
            Menu menu = new(title: () => DisplayPlayerInfo());

            menu.SetMenuList(
            [
                new Choice(
                    index: 1,
                    name: "Create New Goal",
                    callback: () => CreateGoal()
                ),
                new Choice(
                    index: 2,
                    name: "List Goal",
                    callback: () => ListGoalDetails()
                ),
                new Choice(
                    index: 3,
                    name: "Save Goals",
                    callback: () => SaveGoals()
                ),
                new Choice(
                    index: 4,
                    name: "Load Goals",
                    callback: () => LoadGoals()
                ),
                new Choice(
                    index: 5,
                    name: "Record Event",
                    callback: () => RecordEvent()
                ),
                new Choice(
                    index: 6,
                    name: "Quit",
                    quit: true,
                    callback: () => Console.WriteLine("Bye, see you again.")
                )
            ]);
            menu.DisplayMenu();
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"\n-- You have {_score} point(s). --\n");
        }

        public void ListGoalDetails()
        {
            if (_goals.Count > 0)
            {
                Console.WriteLine("\nThe goals are:");
                Console.WriteLine("");

                int index = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                    index++;
                }
            }
            else
            {
                Console.WriteLine("\n> No goal records found.");
            }
        }

        public void CreateGoal()
        {
            SimpleGoal simpleGoal = new();
            EternalGoal eternalGoal = new();
            ChecklistGoal checklistGoal = new();

            Menu menu = new(
                title: () => Console.WriteLine("\nThe types of Goals are:"),
                prompt: "Which type of goal would you like to create? "
            );

            menu.SetMenuList(
                [
                    new Choice(
                        index: 1,
                        name: "Simple Goal",
                        quit: true,
                        callback: () => simpleGoal.CreateGoal(_goals)
                    ),
                    new Choice(
                        index: 2,
                        name: "Eternal Goal",
                        quit: true,
                        callback: () => eternalGoal.CreateGoal(_goals)
                    ),
                    new Choice(
                        index: 3,
                        name: "Checklist Goal",
                        quit: true,
                        callback: () => checklistGoal.CreateGoal(_goals)
                    ),
                ]
            );

            menu.DisplayMenu();
        }

        public void RecordEvent()
        {
            Menu menu = new(
                title: () => Console.WriteLine("\nThe goals are:"),
                prompt: "Which goal did you accomplish? "
            );

            List<Goal> goals = _goals.Where(item => !item.IsCompleted()).ToList();

            if (goals.Count > 0)
            {
                menu.SetMenu(
                    new Choice(
                        index: 0,
                        name: "Go back",
                        quit: true,
                        callback: () => Console.WriteLine("\n> Going back to main menu.")
                    )
                );

                int index = 1;

                foreach (Goal goal in goals)
                {
                    menu.SetMenu(
                        new Choice(
                            index: index,
                            name: goal.GetDescription(),
                            quit: true,
                            callback: () =>
                            {
                                _score += goal.RecordEvent();
                            }
                        )
                    );
                    index++;
                }

                menu.DisplayMenu();

                if (_score > 0)
                {
                    Console.WriteLine($"\n-- You now have {_score} point(s). --");
                }
            }
            else
            {
                Console.WriteLine("\n> No goals to be completed.");
            }
        }

        public void SaveGoals()
        {
            string filepath = "goals.json";

            Console.Write("\nUse default (goals.json) file? (Y/n) ");
            bool confirm = Console.ReadLine().ToLower().Equals("n");

            if (confirm)
            {
                Console.Write("\nWhat is the filename for the goal file save? Ex: goals, without extension. ");
                string filename = Console.ReadLine();
                filepath = $"{filename}.json";
            }

            Console.WriteLine($"\n> Saving {_goals.Count} goals with score {_score}");

            GoalData goalData = new(score: _score, goals: _goals);
            string jsonString = JsonSerializer.Serialize(goalData, _jsonOptions);
            File.WriteAllText(filepath, jsonString);
            Console.WriteLine($"> Goals saved to {filepath}");
        }

        public void LoadGoals()
        {
            string filepath = "goals.json";

            Console.Write("\nUse default (goals.json) file? (Y/n) ");
            bool confirm = Console.ReadLine().ToLower().Equals("n");

            if (confirm)
            {
                Console.Write("\nWhat is the filename for the goal file to load? Ex: goals, without extension. ");
                string filename = Console.ReadLine();
                filepath = $"{filename}.json";
            }

            try
            {
                if (File.Exists(filepath))
                {
                    string jsonString = File.ReadAllText(filepath);
                    GoalData goalData = JsonSerializer.Deserialize<GoalData>(jsonString, _jsonOptions);

                    if (goalData != null)
                    {
                        _goals = goalData.Goals ?? [];
                        _score = goalData.Score;

                        Console.WriteLine($"\n> Goals loaded from {filepath}");
                        Console.WriteLine($"> Loaded {_goals.Count} goals with score {_score}");
                    }
                    else
                    {
                        Console.WriteLine("\n> Failed to load goals - invalid file format.");
                    }
                }
                else
                {
                    Console.WriteLine($"\n> File {filepath} not found.");
                }
            }
            catch (JsonException exception)
            {
                Console.WriteLine($"Error reading JSON file: {exception.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error loading goals: {exception.Message}");
            }
        }
    }
}
