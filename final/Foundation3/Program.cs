using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("----- LECTURE -----");
        Address address1 = new Address("415W 6S", "Rexburg", "Idaho", "USA");
        EventLecture lecture = new EventLecture("Speech", "Nolan Monnier is coming to talk to us", "04/01/2023", "10:00am", address1, "Nolan Monnier", 500);
        lecture.DisplayStandard();
        System.Console.WriteLine();
        lecture.DisplayDescription();
        System.Console.WriteLine();
        lecture.DisplayDetails();
        System.Console.WriteLine();

        System.Console.WriteLine("--- RECEPTION ---");
        Address address2 = new Address("Main Street", "Salt Lake City", "Utah", "USA");
        EventReception reception = new EventReception();
    }
}