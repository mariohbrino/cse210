using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal() { }

        public EternalGoal(
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
            return base.GetPoints();
        }
    }
}
