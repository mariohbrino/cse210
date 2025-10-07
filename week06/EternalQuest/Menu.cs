using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Menu(
        Action title,
        string prompt = "Select a choice from the menu: "
    )
    {
        private Action _title = title;
        private string _prompt = prompt;
        private List<Choice> _choices = [];

        public void SetMenu(Choice choice)
        {
            _choices.Add(choice);
        }

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
            _title.Invoke();

            foreach ((int index, string name) in _choices)
            {
                Console.WriteLine($"  {index}. {name}");
            }

            Console.Write($"\n{_prompt}");
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
