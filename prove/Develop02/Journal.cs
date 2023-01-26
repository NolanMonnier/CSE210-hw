using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _entryResponse = "";

    public string _journalOut = "";
    public List<string> _journalList = new List<string>();

    public void StoreJournal()
    {
        Console.Write("Please enter the name of the file you would like to save your journal to: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_entryResponse}");
        }
    }

    public void LoadJournal()
    {
        Console.Write("Please enter the name of the file you would like to read: ");
        string loadFile = Console.ReadLine();
        string contentFile = File.ReadAllText(loadFile);
        _entryResponse += contentFile;
    }

    public void DisplayJournal()
    {
        Console.WriteLine($"{_entryResponse}");
    }

}