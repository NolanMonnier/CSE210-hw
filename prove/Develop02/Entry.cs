using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    Program program = new Program();
    public string _prompt1 = "What was the highlight of my day?";
    public string _prompt2 = "How did I feel the love of my loved ones today?";
    public string _prompt3 = "What did I do to get closer to the Lord today?";
    public string _prompt4 = "What did you do to bring joy into your life today?";
    public string _prompt5 = "What was I successful at today?";




    public static DateTime theTime = DateTime.Now;
    public string entryDate = theTime.ToShortDateString();



    public string DisplayPrompt(string _entryResponse)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 5);
        string _finalAnswer = "";

        if (number == 1)
        {
            Console.WriteLine($"{_prompt1}");
            Console.Write("Entry: ");
            string _answer = Console.ReadLine();
            Console.Write("How did that make you feel? ");
            string _followUp = Console.ReadLine();
            _finalAnswer = "Date " + entryDate + " Prompt: " + _prompt1 + "\n" + "Entry: " + _answer + "\n" + "Feelings" + _followUp + "\n \n";
        }
        if (number == 2)
        {
            Console.WriteLine($"{_prompt2}");
            Console.Write("Entry: ");
            string _answer = Console.ReadLine();
            Console.Write("How did that make you feel? ");
            string _followUp = Console.ReadLine();
            _finalAnswer = "Date " + entryDate + " Prompt: " + _prompt2 + "\n" + "Entry: " + _answer + "\n" + "Feelings" + _followUp + "\n \n";
        }
        if (number == 3)
        {
            Console.WriteLine($"{_prompt3}");
            Console.Write("Entry: ");
            string _answer = Console.ReadLine();
            Console.Write("How did that make you feel? ");
            string _followUp = Console.ReadLine();
            _finalAnswer = "Date " + entryDate + " Prompt: " + _prompt3 + "\n" + "Entry: " + _answer + "\n" + "Feelings" + _followUp + "\n \n";
        }
        if (number == 4)
        {
            Console.WriteLine($"{_prompt4}");
            Console.Write("Entry: ");
            string _answer = Console.ReadLine();
            Console.Write("How did that make you feel? ");
            string _followUp = Console.ReadLine();
            _finalAnswer = "Date " + entryDate + " Prompt: " + _prompt4 + "\n" + "Entry: " + _answer + "\n" + "Feelings" + _followUp + "\n \n";
        }
        if (number == 5)
        {
            Console.WriteLine($"{_prompt5}");
            Console.Write("Entry: ");
            string _answer = Console.ReadLine();
            Console.Write("How did that make you feel? ");
            string _followUp = Console.ReadLine();
            _finalAnswer = "Date " + entryDate + " Prompt: " + _prompt5 + "\n" + "Entry: " + _answer + "\n" + "Feelings" + _followUp + "\n \n";
        }

        return _finalAnswer;

    }
}