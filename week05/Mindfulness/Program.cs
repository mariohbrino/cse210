using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.SetMenuList(new List<Choice>
            {
                new Choice(
                    index: 1,
                    name: "Start breathing activity",
                    callback: () => Console.WriteLine("Start breathing activity.\n")
                ),
                new Choice(
                    index: 2,
                    name: "Start reflecting activity",
                    callback: () => Console.WriteLine("Start reflecting activity.\n")
                ),
                new Choice(
                    index: 3,
                    name: "Start listing activity",
                    callback: () => Console.WriteLine("Start listing activity.\n")
                ),
                new Choice(
                    index: 4,
                    name: "Quit",
                    quit: true,
                    callback: () => Console.WriteLine("Bye, see you again.")
                )
            });
            menu.DisplayMenu();
        }
    }
}
