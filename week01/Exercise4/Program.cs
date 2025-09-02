using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    private readonly static List<int> listNumbers = [];

    public static void AddNumbers()
    {
        int number;

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                listNumbers.Add(number);
            }
        } while (number != 0);
    }

    public static int SumTotal()
    {
        int sum_total = 0;

        foreach (int value in listNumbers)
        {
            sum_total += value;
        }

        return sum_total;
    }

    public static double AverageNumber(int total)
    {
        int quantitity_amount = listNumbers.Count;

        return (double) total / quantitity_amount;
    }

    public static int LargestNumber()
    {
        return listNumbers.Max();
    }

    public static int SmallestNumber()
    {
        // Filter list number that are grater than zero and find minimim number.
        return listNumbers.Where(number => number > 0).Min();
    }

    public static void PrintSortedList()
    {
        // Sort ascendant list without changing the original order.
        List<int> sortedList = [.. listNumbers.OrderBy(x => x)];

        foreach (int number in sortedList)
        {
            Console.WriteLine(number);
        }
    }

    private static void PrintResults(
        int sum_total,
        double average_number,
        int largest_number,
        int smallest_number
    )
    {
        Console.WriteLine($"The sum is: {sum_total}");
        Console.WriteLine($"The average is: {average_number}");
        Console.WriteLine($"The largest number is: {largest_number}");
        Console.WriteLine($"The smallest positive number is: {smallest_number}");
        PrintSortedList();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        AddNumbers();

        int sum_total = SumTotal();
        double average_number = AverageNumber(sum_total);
        int largest_number = LargestNumber();
        int smallest_number = SmallestNumber();

        PrintResults(sum_total, average_number, largest_number, smallest_number);
    }
}