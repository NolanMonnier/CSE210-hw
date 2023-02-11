using System;
using System.Collections.Generic;
//To exceed the requirement, I asked the user at the beginning how many words they would like to hide. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the scripture memorizer");
        Console.Write("Please enter the largest amount of words you would like to hide: ");
        string _countStr = Console.ReadLine();
        int _count = int.Parse(_countStr);
        List<string> verses = new List<string>
        {
            "Trust in the Lord with all thine heart and lean not unto thine own understanding",
            "In all thy ways acknowledge him and he shall direct thy paths"
        };
        Scripture scripture = new Scripture(verses);

        string _answer = "";
        Console.WriteLine("Here is your scripture:");
        bool _isAllHiden = scripture.IsAllHidden();

        while (_isAllHiden != true)
        {
            scripture.Display();
            Console.WriteLine(" ");
            Console.Write("Please press Enter to hide words, or write Quit to quit: ");
            scripture.HideWords(_count);
            _answer = Console.ReadLine();
            Console.WriteLine(" ");
            if (_answer == "Quit")
            {
                break;
            }
            _isAllHiden = scripture.IsAllHidden();
        }

        if (_isAllHiden == true)
        {
            scripture.Display();
            Console.WriteLine(" ");
            Console.Write("Please press enter to hide words, or write Quit to quit: ");
            Console.ReadLine();
        }


        Console.WriteLine("Quitting...");

    }
}