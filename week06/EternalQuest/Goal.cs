using System;
using System.Text.Json.Serialization;

namespace EternalQuest
{
    [JsonDerivedType(typeof(SimpleGoal), "SimpleGoal")]
    [JsonDerivedType(typeof(EternalGoal), "EternalGoal")]
    [JsonDerivedType(typeof(ChecklistGoal), "ChecklistGoal")]
    public abstract class Goal
    {
        [JsonInclude]
        [JsonPropertyName("shortName")]
        protected string _shortName;

        [JsonInclude]
        [JsonPropertyName("description")]
        protected string _description;

        [JsonInclude]
        [JsonPropertyName("points")]
        protected int _points;

        [JsonInclude]
        [JsonPropertyName("isCompleted")]
        protected bool _isCompleted = false;

        public Goal()
        {
            // pass
        }

        public Goal(
            string name,
            string description,
            int points
        )
        {
            _shortName = name;
            _description = description;
            _points = points;

        }

        public string GetShortName()
        {
            return _shortName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetPoints()
        {
            return _points;
        }

        public void SetShortName(string name)
        {
            _shortName = name;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public void SetPoints(int point)
        {
            _points = point;
        }

        public static int PromptNumericValue(string prompt)
        {
            int response;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    response = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\n[ERROR] Invalid input. Please enter a valid number.\n");
                }
            }
            return response;
        }

        public virtual void CreateGoal(List<Goal> goals)
        {
            Console.Write("\nWhat is the name of your goal? ");
            string name = Console.ReadLine();
            SetShortName(name);

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            SetDescription(description);

            int points = PromptNumericValue("What is the amount of points associated with this goal? ");
            SetPoints(points);

            goals.Add(this);
        }

        public virtual int RecordEvent()
        {
            SetCompleted();
            Console.WriteLine($"\nCongratulations! You have earned {_points} point(s).");
            return _points;
        }

        public virtual void SetCompleted()
        {
            _isCompleted = true;
        }

        public virtual bool IsCompleted()
        {
            return _isCompleted;
        }

        public virtual string GetDetailsString()
        {
            return $"[{(IsCompleted() ? 'X' : ' ')}] {_shortName} ({_description})";
        }

        public abstract string GetStringRepresentation();
    }
}
