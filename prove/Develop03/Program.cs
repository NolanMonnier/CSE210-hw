using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer");
        List<string> verses = new List<string>
        {
            "Trust in the Lord with all thine heart and lean not unto thine own understanding",
            "In all thy ways acknowledge him and he shall direct thy paths"
        };
        Scripture scripture = new Scripture(verses);

        string _answer = "";
        Console.WriteLine("Here is your scripture:");
        bool _isAllHiden = scripture.IsAllHidden();

        while (_answer != "Quit" && _isAllHiden != true)
        {
            scripture.Display();
            Console.WriteLine(" ");
            Console.Write("Please press Enter to hide words, or write Quit to quit");
            scripture.HideWords(3);
            _answer = Console.ReadLine();
            Console.WriteLine(" ");
            _isAllHiden = scripture.IsAllHidden();
        }
        scripture.Display();
        Console.WriteLine(" ");
        Console.Write("Please press enter to hide words, or write Quit to quit");
        Console.ReadLine();


        Console.WriteLine("Quitting...");

    }
}