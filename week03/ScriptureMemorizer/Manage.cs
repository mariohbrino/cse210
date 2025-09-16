using System;

class Manage
{
    private readonly List<Scripture> _scriptures = [];

    private static string PromptValue(string label)
    {
        string value = null;
        do
        {
            Console.WriteLine(label);
            value = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(value));
        return value;
    }

    private static int PromptIntValue(string label)
    {
        int value;
        while (true)
        {
            Console.WriteLine(label);
            string input = Console.ReadLine();
            if (int.TryParse(input, out value))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        return value;
    }

    public bool HasScripture()
    {
        return _scriptures.Count > 0;
    }

    public Scripture GetRandonScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public void CreateScripture()
    {
        Console.WriteLine("Creating a scripture");
        string book = PromptValue("What is the book?");
        int chapter = PromptIntValue("What is the chapter?");
        int verse = PromptIntValue("What is the verse?");
        string content = PromptValue("What is the content?");
        Reference reference = new Reference(book, chapter, verse);
        Scripture scripture = new Scripture(reference, content);
        AddScripture(scripture);
        Console.WriteLine("Scripture created with success.");
    }

    public void MemorizeScripture()
    {
        if (HasScripture())
        {
            Scripture scripture = GetRandonScripture();
            scripture.ReverseHideWords();
            scripture.GetDisplayText();
        }
        else
        {
            Console.WriteLine("No scripture found, create a new scripture.");
        }
    }
}