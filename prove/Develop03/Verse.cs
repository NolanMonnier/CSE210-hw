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

    public bool IsAllHidden()
    {
        foreach (Word word in _text)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideWords()
    {
        if (!IsAllHidden())
        {
            var random = new Random();
            int index = random.Next(_text.Count);
            Word _wordToHide = _text[index];
            while (_wordToHide.IsHidden())
            {
                index = random.Next(_text.Count);
                _wordToHide = _text[index];
            }
            _text[index].HideWord(_wordToHide);
        }

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