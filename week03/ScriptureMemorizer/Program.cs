using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "And it came to pass that I beheld a tree, whose fruit was desirable to make one happy.";
        Reference reference = new Reference("1 Nephi", 8, 10);
        Scripture scripture = new Scripture(reference, text);
        scripture.GetDisplayText();
    }
}