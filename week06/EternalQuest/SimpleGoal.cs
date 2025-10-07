using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal()
        {
            // pass
        }

        public SimpleGoal(
            string name,
            string description,
            int points
        ) : base(name, description, points)
        {
            // pass
        }

        public override void CreateGoal(List<Goal> goals)
        {
            base.CreateGoal(goals);
        }

        public override int RecordEvent()
        {
            return base.RecordEvent();
        }

        public override bool IsCompleted()
        {
            return base.IsCompleted();
        }

        public override string GetStringRepresentation()
        {
            return $"Goal (shortName: {GetShortName()}, description: {GetDescription()}, points: {GetPoints()})";
        }
    }
}
