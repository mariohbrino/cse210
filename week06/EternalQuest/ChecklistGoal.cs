using System;
using System.Drawing;
using System.Text.Json.Serialization;

namespace EternalQuest
{
    public class ChecklistGoal: Goal
    {
        [JsonInclude]
        [JsonPropertyName("amountCompleted")]
        protected int _amountCompleted = 0;

        [JsonInclude]
        [JsonPropertyName("target")]
        protected int _target;

        [JsonInclude]
        [JsonPropertyName("bonus")]
        protected int _bonus;

        public ChecklistGoal()
        {
            // pass
        }

        public ChecklistGoal(
            string name,
            string description,
            int points,
            int target,
            int bonus
        ) : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
        }

        public override void CreateGoal(List<Goal> goals)
        {
            base.CreateGoal(goals);

            int target = PromptNumericValue("How many times does this goal need to be accomplished for a bonus? ");
            _target = target;

            int bonus = PromptNumericValue("What is the bonus for accomplishing it that many times? ");
            _bonus = bonus;
        }

        public override int RecordEvent()
        {
            int points = GetPoints();
            if (_amountCompleted < _target)
            {
                _amountCompleted++;
                if (_amountCompleted == _target)
                {
                    SetCompleted();
                }
            }

            if (base.IsCompleted())
            {
                points += _bonus;
            }

            Console.WriteLine($"\nCongratulations! You have earned {points} point(s).");
            return points;
        }

        public override bool IsCompleted()
        {
            return base.IsCompleted();
        }

        public override string GetDetailsString()
        {
            return $"[{(IsCompleted() ? 'X' : ' ')}] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"Goal (shortName: {GetShortName()}, description: {GetDescription()}, points: {GetPoints()})";
        }
    }
}
