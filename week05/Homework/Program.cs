using System;
using System.Threading.Tasks.Dataflow;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Assingment assingment1 = new Assingment("Samuel Bennett", "Multiplication");
            Console.WriteLine(assingment1.GetSummary());

            Console.WriteLine("");

            MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(assignment2.GetHomeworkList());

            Console.WriteLine("");

            WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
            Console.WriteLine(assignment3.GetWritingInformation());
        }
    }
}
