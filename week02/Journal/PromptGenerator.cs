using System;

class PromptGenerator
{
    private readonly List<string> _options = [
        "What was the best part of your day and why?",
        "Describe a challenge you faced today and how you handled it.",
        "What is something new you learned recently?",
        "Write about someone you are grateful for and why.",
        "What is a goal you want to achieve this week?",
        "Reflect on a recent conversation that made you think.",
        "How are you feeling right now? Explain your emotions.",
        "What is one thing you would like to improve about yourself?",
    ];

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_options.Count);
        string promptValue = _options[index];
        return promptValue;
    }
}
