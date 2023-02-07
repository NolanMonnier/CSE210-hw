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


        //scripture.Display();
        scripture.RandomVerse(verses);

    }
}