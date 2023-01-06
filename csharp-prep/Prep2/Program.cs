using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        string letter;
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage < 94 && percentage > 59)
        {
            if (percentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (percentage % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congrats! You passed the class.");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Better luck next time.");
        }
    }
}