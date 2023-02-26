using System;

public class Reflecting : Activity
{
    private int _duration = 0;
    List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

    public Reflecting() : base("Welcome to the Reflecting Activity",
                              "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                              "Reflecting",
                              0,
                              "Well Done!!")
    {

    }

    public Reflecting(int duration) : base("Welcome to the Reflecting Activity",
                                          "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                                          "Reflecting",
                                          duration,
                                          "Well Done!!")
    {
        _duration = duration;
    }

    public void DisplayReflectingExo()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);

        System.Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"--- {_prompts[index]} ---");
        System.Console.WriteLine(" ");
        System.Console.Write("When you have something in mind, press enter to continue");
        Console.ReadLine();
        System.Console.WriteLine(" ");
        System.Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        System.Console.Write("You may begin in: ");
        DisplayTimer(5);
        Console.Clear();

        while (_duration > 0)
        {
            int question = random.Next(_questions.Count);
            System.Console.Write($"{_questions[question]} ");
            DisplayTimer(9);
            System.Console.WriteLine(" ");
            _duration -= 10;
        }
        DisplayEnding();
    }
}