using System;
using System.Collections.Generic;

public class Verse
{
    private List<Word> _text = new List<Word>();

    public Verse()
    {

    }
    public Verse(string verse)
    {
        string[] words = verse.Split(" ");
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _text.Add(word);
        }
    }

    public void RandomWord(List<Verse> verses)
    {
        var random = new Random();
        int index = random.Next(verses.Count);
        Console.WriteLine(verses[index]);
    }

    public void Display()
    {
        foreach (Word w in _text)
        {
            w.Display();
            Console.Write(" ");
        }
    }
}