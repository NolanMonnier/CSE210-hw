using System;
using System.IO;

// ----- EXTRA WORK -----
//For the extra work, I added a follow question after the user answers, by asking them "How did that make you feel?"

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Entry entry = new Entry();
        Journal journal = new Journal();

        int number = 0;
        while (number < 5)
        {
            menu.DisplayMenu();
            string num = Console.ReadLine();
            number = int.Parse(num);
            if (number == 1)
            {
                journal._entryResponse += entry.DisplayPrompt(journal._entryResponse);
            }
            if (number == 2)
            {
                journal.DisplayJournal();
            }
            if (number == 3)
            {
                journal.LoadJournal();
            }
            if (number == 4)
            {
                journal.StoreJournal();
            }
            if (number == 5)
            {
                Console.WriteLine("Quitting...");
            }

        }





    }
}