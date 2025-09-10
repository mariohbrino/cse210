using System;
using System.Net;

class Program
{
    private static int SelectMenu()
    {
        List<Choise> choices = [
            new Choise { _index = 1, _name = "Write" },
            new Choise { _index = 2, _name = "Display" },
            new Choise { _index = 3, _name = "Load" },
            new Choise { _index = 4, _name = "Save" },
            new Choise { _index = 5, _name = "Quit" },
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
            int choise = SelectMenu();
            switch (choise)
            {
                case 1:
                    journal.Record();
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    journal.LoadFromFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;
                case 5:
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