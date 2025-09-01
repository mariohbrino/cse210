using System;

class Program
{

    public static string GradePerformance(int performance)
    {
        string signal = "";

        if (performance >= 7)
        {
            signal = "+";
        }
        else if (performance < 3)
        {
            signal = "-";
        }

        return signal;
    }
    public static string GradeLetter(double percentage)
    {
        string letter = "";
        string signal = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        if (percentage < 93 && percentage >= 60)
        {
            int performance = (int)(percentage % 10);

            signal = GradePerformance(performance);
        }

        return letter + signal;
    }

    public static string GradePassed(double percentage)
    {
        if (percentage < 70)
        {
            return $"You have not passed, with a score of {percentage}.";
        }
        return $"You passed, with a score of {percentage}.";
    }

    static void Main(string[] args)
    {
        if (args[0] == "testing")
        {
            List<int> gradeList = new List<int>() { 50, 63, 69, 73, 79, 83, 89, 93, 99 };

            foreach (int test_grade_percentage in gradeList)
            {
                string test_grade_letter = GradeLetter(test_grade_percentage);
                Console.WriteLine($"Your grade is {test_grade_letter}");
                Console.WriteLine(GradePassed(test_grade_percentage));
                Console.WriteLine("");
            }
        }
        else
        {
            Console.Write("What is your grade percentage? ");
            string grade_percentage = Console.ReadLine();
            string grade_letter = GradeLetter(double.Parse(grade_percentage));
            Console.WriteLine($"Your grade is {grade_letter}");
            Console.WriteLine(GradePassed(double.Parse(grade_percentage)));
        }
    }
}