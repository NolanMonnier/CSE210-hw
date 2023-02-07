using System;
using System.Collections.Generic;

public class Word
{
    private string _text = "";

    public Word(string word)
    {
        _text = word;
    }

    public void Display()
    {
        Console.Write(_text);
    }

}