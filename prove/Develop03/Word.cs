using System;
using System.Collections.Generic;

public class Word
{
    private string _text = "";
    private bool _hidden = false;

    public Word(string word)
    {
        _text = word;
    }

    public void Display()
    {
        if (!_hidden)
        {
            Console.Write(_text);
        }
        else
        {
            foreach (char letter in _text)
            {
                Console.Write("_");
            }
        }
    }

    public void HideWord(Word word)
    {
        _hidden = true;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
}