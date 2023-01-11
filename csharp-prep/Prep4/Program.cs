using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list pf numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        int input = 1;
        do
        {
            Console.WriteLine("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
    }
}