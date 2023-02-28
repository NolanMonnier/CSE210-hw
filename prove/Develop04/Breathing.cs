using System;

public class Breathing : Activity
{
    private int _duration = 0;
    public Breathing() : base("Welcome to the Breathing Activity",
                              "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                              "Breathing",
                              0,
                              "Well Done!!")
    {

    }

    public Breathing(int duration) : base("Welcome to the Breathing Activity",
                                          "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                                          "Breathing",
                                          duration,
                                          "Well Done!!")
    {
        _duration = duration;
    }

    public void DisplayBreathingExo()
    {
        while (_duration > 0)
        {
            System.Console.Write("Breath in... ");
            DisplayTimer(5);
            System.Console.WriteLine();
            System.Console.Write("Breath out... ");
            DisplayTimer(5);

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
            _duration -= 10;
        }
        DisplayEnding();

    }
}
