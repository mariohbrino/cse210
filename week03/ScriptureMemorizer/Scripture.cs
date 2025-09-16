using System;

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        SetWords(text);
    }

    public void SetWords(string text)
    {
        string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string item in words)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int iteration = 1; iteration <= numberToHide; iteration++)
        {
            List<Word> visibleWords = [.. _words.Where(word => !word.IsHidden())];
            if (visibleWords.Count == 0) break;
            int index = random.Next(visibleWords.Count);
            Word word = visibleWords[index];
            word.Hide();
        }
    }

    public void ReverseHideWords()
    {
        List<Word> hiddenWords = [.. _words.Where(word => word.IsHidden())];
        foreach (Word word in hiddenWords)
        {
            word.Show();
        }
    }

    public void GetDisplayText()
    {
        bool completed = false;
        do
        {
            string text = string.Join(" ", [.. _words.Select(word => word.GetDisplayText())]);
            Console.WriteLine($"{_reference.ToString()} {text}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();

            // Check if the user wants to quit
            if (response.ToLower() == "quit")
            {
                completed = true;
                break;
            }

            // Hide three random words
            HideRandomWords(3);
            Console.Clear();

            // Verify if all words are hidden and complete the loop
            if (IsCompletelyHidden())
            {
                completed = true;
                break;
            }
        } while (completed == false);
    }

    public bool IsCompletelyHidden()
    {
        List<Word> visibleWords = [.. _words.Where(word => !word.IsHidden())];
        return visibleWords.Count == 0;
    }
}
