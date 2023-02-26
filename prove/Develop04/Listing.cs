using System;

public class Listing : Activity
{
    private int _duration = 0;
    List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month",
            "Who are some of your personal heroes?"
        };
    public Listing() : base("Welcome to the Listing Activity",
                              "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                              "Listing",
                              0,
                              "Well Done!!")
    {

    }

    public Listing(int duration) : base("Welcome to the Listing Activity",
                              "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                              "Listing",
                              duration,
                              "Well Done!!")
    {
        _duration = duration;
    }

    public void DisplayListingExo()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        int count = 0;

        System.Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"--- {_prompts[index]} ---");
        System.Console.WriteLine(" ");
        System.Console.Write("When you have something in mind, press enter to continue");
        Console.ReadLine();
        System.Console.WriteLine("Write down as many responses you can to the following prompt:");
        System.Console.WriteLine("");
        System.Console.Write("You may begin in: ");
        DisplayTimer(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            Console.ReadLine();
            currentTime = DateTime.Now;
            count++;
        }

        System.Console.WriteLine($"You listed {count} items!");
        System.Console.WriteLine(" ");
        DisplayEnding();
    }
}