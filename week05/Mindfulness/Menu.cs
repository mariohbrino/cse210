using System;

namespace Mindfulness
{
    class Menu
    {
        private List<Choice> _choices = [];

        public void SetMenuList(List<Choice> choices)
        {
            _choices.AddRange(choices);
        }

        private Choice FindChoise(int index)
        {
            return _choices.Find(choice => choice.GetIndex() == index);
        }

        public int SelectMenu()
        {
            Console.WriteLine("Menu Options:");

            foreach ((int index, string name) in _choices)
            {
                Console.WriteLine($"{index}. {name}");
            }

            Console.Write("Select a choice from the menu: ");
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

        public void DisplayMenu()
        {
            bool quit = false;
            do
            {
                int selectedIndex = SelectMenu();
                Choice choice = FindChoise(selectedIndex);
                if (choice == null)
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.\n");
                }
                else if (choice.GetQuit())
                {
                    choice.ExecuteCallback();
                    break;
                }
                else
                {
                    choice.ExecuteCallback();
                }
            } while (quit == false);
        }
    }
}
