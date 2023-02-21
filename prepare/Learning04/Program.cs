using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Michael", "Multiplication");
        Console.WriteLine(assignment1.GetAssignmentHeader());

        MathAssignment assignment2 = new MathAssignment("Michael", "Division", "1-7", "#1-10");
        Console.WriteLine(assignment2.GetAssignmentHeader());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Thomas", "Greek Mythology", "The Tale of Hercules");
        Console.WriteLine(assignment3.GetAssignmentHeader());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}