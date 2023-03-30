using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("----- LECTURE -----");
        Address address1 = new Address("Grand'Rue 6", "Le Sentier", "Vaud", "Switzerland");
        EventLecture lecture = new EventLecture("Speech", "Nolan Monnier is coming to talk to us", "04/01/2023", "10:00am", address1, "Nolan Monnier", 500);
        lecture.DisplayStandard();
        System.Console.WriteLine();
        lecture.DisplayDescription();
        System.Console.WriteLine();
        lecture.DisplayDetails();
        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("----- RECEPTION -----");
        Address address2 = new Address("Main Street", "Salt Lake City", "Utah", "USA");
        EventReception reception = new EventReception("Wedding of Mike & Julie", "The Smith's are getting married!!", "06/07/2023", "1:30pm", address2, "mon21025@byui.edu");
        reception.DisplayStandard();
        System.Console.WriteLine();
        reception.DisplayDescription();
        System.Console.WriteLine();
        reception.DisplayDetails();
        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("----- OUTDOOR -----");
        Address address3 = new Address("415W 6S", "Rexburg", "Idaho", "USA");
        EventOutdoor outdoor = new EventOutdoor("John's Birthday Party", "Come celebrate John's birthday", "04/10/2023", "4:00pm", address3, "It's Idaho... In April... It'll be snowing!");
        outdoor.DisplayStandard();
        System.Console.WriteLine();
        outdoor.DisplayDescription();
        System.Console.WriteLine();
        outdoor.DisplayDetails();
        System.Console.WriteLine();
    }
}