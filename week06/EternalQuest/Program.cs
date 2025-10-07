using System;

// Enhancements:
// 1. Custom Menu/Choice framework for improved user experience
// 2. Flexible file naming system for save/load operations
// 3. Save and load game state using JSON serialization
// 4. Robust error handling for JSON parsing and file operations
// 5. Input validation with user-friendly error messages
// 6. Enhanced checklist goal display showing progress (X/Y format)

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new();
            goalManager.Start();
        }
    }
}
