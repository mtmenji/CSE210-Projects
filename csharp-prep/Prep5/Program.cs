using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squareNum = SquareNumber(userNum);
        Console.Write($"Brother {userName}, the square root of your number is {squareNum}.");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquareNumber(int userNum)
    {
        int squareNum = userNum * userNum;
        return squareNum;
    }
}