using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        string letter = "";
        string symbol = "";

        if (number >= 90)
        {
            letter = "A";
        }

        else if (number >= 80 && number < 90)
        {
            letter = "B";
        }

        else if (number >= 70 && number < 80)
        {
            letter = "C";
        }

        else if (number >= 60 && number < 70)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if ((number % 10) >= 7)
        {
            symbol = "+";
        }

        else if ((number % 10) < 3)
        {
            symbol = "-";
        }


        if (number > 93)
        {
            symbol = "";
        }

        else if (letter == "F")
        {
            symbol = "";
        }


        Console.WriteLine($"Your letter grade is {letter}{symbol}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!!");
        }

        else
        {
            Console.WriteLine("My dude! You suck... Try again next semester, and hopefuly it'll be better");
        }
    }
}