using System;
using System.IO;

class Journal
{
    private readonly List<Entry> _entries = [];

    public void Record()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string promptValue = promptGenerator.GetRandomPrompt();
        Console.WriteLine(promptValue);
        string response = Console.ReadLine();
        DateTime now = DateTime.Now;
        _entries.Add(
            new Entry
            {
                _prompt = promptValue,
                _response = response,
                _createdAt = now.ToString("yyyy-MM-dd"),
            }
        );
    }

    public void DisplayAll()
    {
        if (_entries.Count > 0)
        {
            foreach (var (prompt, response, createdAt) in _entries)
            {
                Console.WriteLine($"{createdAt} - Prompt: {prompt}");
                Console.WriteLine(response);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No entries found. Write a journal entry or load from a file.");
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string filname = Console.ReadLine();

        if (filname != "")
        {
            if (_entries.Count > 0)
            {
                using StreamWriter outputFile = new StreamWriter(filname);
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.ToString());
                }
                Console.WriteLine($"[{_entries.Count}] were saved into {filname}.");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string filname = Console.ReadLine();

        if (filname != "")
        {
            if (File.Exists(filname))
            {
                string[] lines = System.IO.File.ReadAllLines(filname);
                _entries.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    _entries.Add(
                        new Entry
                        {
                            _prompt = parts[0],
                            _response = parts[1],
                            _createdAt = parts[2],
                        }
                    );
                }
                Console.WriteLine($"[{_entries.Count}] entries were loaded in memory.");
            }
            else
            {
                Console.WriteLine($"File {filname} not found, try again or check if the file exists.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please provide a valid filename.");
        }
    }
}
