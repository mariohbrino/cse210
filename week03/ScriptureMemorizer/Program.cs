using System;

// Requirements:
// 1. Principle: Encapsulation (information hiding)
//    All member variables are private.
// 2. Principle: Scripture class
//    A class is present that encapsulates the responsibilities of a scripture. Behavior that
//    is specific to Sscriptures is all done by this class, not in other places in the program.
//    And, this class does not include items or behaviors that do not pertain to it.
// 3. Principle: Word class
//    A class is present that encapsulates the responsibilities of a word (including that the word
//    class is responsible for storing its own shown/hidden state). Behavior that is specific to words
//    is all done by this class, not in other places in the program. And, this class does not include
//    items or behaviors that do not pertain to it.
// 4. Principle: Reference class
//    A class is present that encapsulates the responsibilities of a reference (including handling multiple
//    verses). Behavior that is specific to references is all done by this class, not in other places in
//    the program. And, this class does not include items or behaviors that do not pertain to it.
// 5. Functionality: Scripture Display
//    A scripture is displayed.
// 6. Functionality: Word Hiding
//    Repeatedly pressing enter causes words to be replaced with underscores. The number of underscores
//    matches the number of letters in the word.
// 7. Functionality: Program Termination
//    The program continues until all words are hidden or the user types quit.
// 8. Style: Whitespace and File Organization
//    Each class is defined in its own file and the name of the file exactly matches the class name.
//    Vertical and horizontal whitespace (blank lines, indentation, braces) is correct throughout the
//    program.
// 9. Style: Naming Conventions
//    Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use
//    camelCase.
// 10. Shows creativity and exceeds core requirements
//    The program exceeds the core requirements as explained in comments in the Program.cs.

// Creativity:
// - Added a seletion menu to add scripture, memorize random scripture, and quit app.
// - Select random scritpure.
// - Reverse scripture hide words after quit.

class Program
{
    private static int SelectMenu()
    {
        List<Choice> choices = [
            new Choice(1, "Add Scritpure"),
            new Choice(2, "Memorize Random Scripture"),
            new Choice(3, "Quit"),
        ];

        Console.WriteLine("Please select one of the following choices:");

        foreach ((int index, string name) in choices)
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
        bool quit = false;
        Manage manage = new Manage();
        do
        {
            int choice = SelectMenu();
            switch (choice)
            {
                case 1:
                    manage.CreateScripture();
                    break;
                case 2:
                    manage.MemorizeScripture();
                    break;
                case 3:
                    Console.WriteLine("Bye, see you again.");
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        } while (quit == false);
    }

    static void Main(string[] args)
    {
        DisplayMenu();
    }
}