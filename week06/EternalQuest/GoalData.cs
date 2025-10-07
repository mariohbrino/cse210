using System;
using System.Text.Json.Serialization;

namespace EternalQuest
{
    public class GoalData
    {
        [JsonPropertyName("score")]
        public int Score { get; set; }
        
        [JsonPropertyName("goals")]
        public List<Goal> Goals { get; set; }

        public GoalData() { }
        
        public GoalData(int score, List<Goal> goals)
        {
            Score = score;
            Goals = goals;
        }
    }
}
