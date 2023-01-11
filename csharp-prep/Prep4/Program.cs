using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int numbers = -1;
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numbers != 0)
        {
            Console.Write("Enter number: ");
            numbers = int.Parse(Console.ReadLine());
            if (numbers != 0)
            {
                numberList.Add(numbers);
                sum += numbers;
            }
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is {average}");

        int max = numberList.Max();
        Console.WriteLine($"The largest number is {max}");
    }
}