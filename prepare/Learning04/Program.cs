using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        System.Console.WriteLine(assignment1.GetSummary());
        System.Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        System.Console.WriteLine(mathAssignment1.GetSummary());
        System.Console.WriteLine(mathAssignment1.GetHomeworkList());
        System.Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        System.Console.WriteLine(writingAssignment1.GetSummary());
        System.Console.WriteLine(writingAssignment1.GetHomeworkList());

    }
}