using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public bool IsAllHidden()
    {
        foreach (Verse verse in _verses)
        {
            if (!verse.IsAllHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideWords(int count)
    {
        int i = 0;
        while (i < count)
        {
            var random = new Random();
            int index = random.Next(_verses.Count);
            _verses[index].HideWords();

            if (IsAllHidden() == true)
            {
                break;
            }

            i += 1;
        }
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