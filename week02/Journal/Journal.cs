using System;
using System.IO;
using System.Text.Json;

class Journal
{
    private readonly List<Entry> _entries = [];

    public void RecordEntry()
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
                _createdAt = now.ToString("yyyy/mm/dd"),
            }
        );
    }

    public void DisplayEntries()
    {
        if (_entries.Count > 0)
        {
            foreach (var (prompt, response, createdAt) in _entries)
            {
                Console.WriteLine($"Date: {createdAt} - Prompt: {prompt}");
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
            else
            {
                Console.WriteLine("No entries found. Register entries or load from file before saving.");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string filname = Console.ReadLine();

        if (filname != "" && !filname.Contains(".json"))
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
                            _prompt = parts[2],
                            _response = parts[1],
                            _createdAt = parts[0],
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

    public string Serialize()
    {
        return JsonSerializer.Serialize(
            _entries,
            new JsonSerializerOptions { WriteIndented = true }
        );
    }

    public void SaveToJsonFile()
    {
        Console.WriteLine("What is the filename?");
        string filname = Console.ReadLine();

        if (filname != "")
        {
            if (_entries.Count > 0)
            {
                if (!filname.Contains(".json"))
                {
                    filname += ".json";
                }
                using StreamWriter outputFile = new StreamWriter(filname);
                outputFile.Write(Serialize());
            }
            else
            {
                Console.WriteLine("No entries found. Register entries or load from file before saving.");
            }
        }
    }
}
