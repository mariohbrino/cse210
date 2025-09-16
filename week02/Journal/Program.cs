using System;
using System.Net;

// Requirements:
// 1. Principle: Journal Abstraction
//   A class models the responsibilities of a journal and does not include items that do not pertain
//   to a journal.
// 2. Principle: Entry Abstraction
//   A class models the responsibilities of an entry and does not include items that do not pertain to
//   an entry.
// 3. Functionality: Journal Writing
//   A journal entry is written and stored along with the date.
// 4. Functionality: Journal Display
//   All journal entries can be displayed along with the date and prompt associated with that entry.
// 5. Functionality: Prompt Generation
//  A set of writing prompts is chosen from randomly and displayed.
// 6. Functionality: Saving
//   The journal can be saved to a file.
// 7. Functionality: Loading
//   The journal can be loaded from a file.
// 8. Style: Whitespace and File Organization
//   Each class is defined in its own file and the name of the file exactly matches the class name.
//   Vertical and horizontal whitespace (blank lines, indentation, braces) is correct throughout the
//   program.
// 9. Style: Naming Conventions
//   Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use
//   camelCase.
// 10. Shows creativity and exceeds core requirements
//   The program exceeds the core requirements as explained in comments in the Program.cs

// Creativity:
// Save entries to json file.
// Defined a Choice abstraction for menu list.

class Program
{
    private static int SelectMenu()
    {
        List<Choice> choices = [
            new Choice { _index = 1, _name = "Write" },
            new Choice { _index = 2, _name = "Display" },
            new Choice { _index = 3, _name = "Load" },
            new Choice { _index = 4, _name = "Save" },
            new Choice { _index = 5, _name = "Save as Json" },
            new Choice { _index = 6, _name = "Quit" },
        ];

        Console.WriteLine("Please select one of the following choices:");

        foreach (var (index, name) in choices)
        {
            Console.WriteLine($"{index}. {name}");
        }

        Console.Write("What would you like to do? ");
        try
        {
            int response = int.Parse(Console.ReadLine());
            return response;
        }
        catch (FormatException exception)
        {
            Console.WriteLine($"Invalid input. Please enter a valid number. [ERROR] => {exception.Message}");
        }

        return 0;
    }

    private static void DisplayMenu()
    {
        bool response = true;

        Journal journal = new();

        do
        {
            int choice = SelectMenu();
            switch (choice)
            {
                case 1:
                    journal.RecordEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.LoadFromFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;
                case 5:
                    journal.SaveToJsonFile();
                    break;
                case 6:
                    Console.WriteLine("Bye, see you again.");
                    response = false;
                    break;
                default:
                    break;
            }
        } while (response);
    }

    static void Main(string[] args)
    {
        DisplayMenu();
    }
}