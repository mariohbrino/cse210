using System;

class Program
{
    public static bool GuessNumber(int magic_number, int guessed_number)
    {
        if (magic_number == guessed_number)
        {
            Console.WriteLine("You guessed it!");
            return false;
        } else if (magic_number > guessed_number)
        {
            Console.WriteLine("Higher");
        }
        else if (magic_number < guessed_number)
        {
            Console.WriteLine("Lower");
        }
        return true;
    }

    public static int GenerateMagicNumber()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        return number;
    }

    public static void StartGame()
    {
        int magic_number = GenerateMagicNumber();
        bool result = true;
        int tries = 0;

        do
        {
            Console.Write("What is your guess? (1-100) ");
            int guessed_number = int.Parse(Console.ReadLine());
            result = GuessNumber(magic_number, guessed_number);
            tries += 1;
        } while (result);
        Console.WriteLine($"You have tried {tries} times.");
    }

    public static bool StillPlaying()
    {
        Console.Write("Are you still playing? (yes, no) ");
        string playing = Console.ReadLine();

        if (playing.ToLower() == "yes")
        {
            return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        bool playing = true;

        do
        {
            StartGame();
            playing = StillPlaying();
        } while (playing);
        Console.WriteLine("Bye bye, see you again.");
    }
}