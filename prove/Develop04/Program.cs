using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        int count = 0;
        int totalTime = 0;

        while (answer < 4)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("Welcome to the mindfulness activity");
            }

            if (count == 1)
            {
                System.Console.WriteLine($"You have completed {count} activity.");
                System.Console.WriteLine($"You have done the activity for {totalTime} seconds.");
            }
            if (count > 1)
            {
                System.Console.WriteLine($"You have completed {count} activities.");
                System.Console.WriteLine($"You have done activities for {totalTime} seconds.");
            }
            System.Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string _menuAnswer = Console.ReadLine();
            answer = int.Parse(_menuAnswer);

            if (answer == 1)
            {
                Breathing breathingBasic = new Breathing();
                int seconds = breathingBasic.DisplayIntro();
                Breathing breathing = new Breathing(seconds);
                breathing.DisplayBreathingExo();
                totalTime += seconds;
                count++;
            }

            if (answer == 2)
            {
                Reflecting reflectingBasic = new Reflecting();
                int seconds = reflectingBasic.DisplayIntro();
                Reflecting reflecting = new Reflecting(seconds);
                reflecting.DisplayReflectingExo();
                totalTime += seconds;
                count++;
            }
            if (answer == 3)
            {
                Listing listingBasic = new Listing();
                int seconds = listingBasic.DisplayIntro();
                Listing listing = new Listing(seconds);
                listing.DisplayListingExo();
                totalTime += seconds;
                count++;
            }
        }

        if (answer > 3)
        {
            if (count == 0)
            {

            }
            if (count == 1)
            {
                System.Console.WriteLine($"Congratulations on completing {count} activity!");
                System.Console.WriteLine($"You have done the activity for {totalTime} seconds.");
                System.Console.WriteLine("We hope this could help you with your mental health");
            }
            if (count > 1)
            {
                System.Console.WriteLine($"Congratulations on completing {count} activities!");
                System.Console.WriteLine($"You have done activities for {totalTime} seconds.");
                System.Console.WriteLine("We hope this could help you with your mental health");
            }
        }
    }
}