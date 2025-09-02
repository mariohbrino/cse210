using System;

class Program
{
    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    public static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string fullname = Console.ReadLine();
        return fullname;
    }

    public static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoritNumber = int.Parse(Console.ReadLine());
        return favoritNumber;
    }

    public static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    public static void DisplayResult(string fullname, int squareNumber)
    {
        Console.WriteLine($"{fullname}, the square of your number is {squareNumber}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string fullname = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(fullname, squareNumber);
    }
}