using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    public string _hiddenVerse = "";

    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }
    public void RandomVerse(List<string> verses)
    {
        var random = new Random();
        int index = random.Next(verses.Count);
        Verse ver = new Verse();
        ver.RandomWord(_verses);
        //Console.WriteLine(verses[index]);
    }

    public void Display()
    {
        foreach (Verse v in _verses)
        {
            v.Display();
            Console.WriteLine(" ");
        }
    }
}