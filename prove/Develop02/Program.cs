using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        // Continue looping through the menu until the user decides to quit         
        while (true) {
            // Display Menu to terminal and receive user choice.
            Console.WriteLine("Please select on of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) {
                Entry entry = new Entry();
                entry.EntryCreator();
                
                // Add the entry to the journal.
                journal.journalEntries.Add(entry);
                Console.WriteLine();

            } else if (userChoice == 2) {
                journal.Display();

            } else if (userChoice == 3) {
                journal.Load();

            } else if (userChoice == 4) {
                journal.Save();

            } else if (userChoice == 5) {
                break;
            }
        }
    }
}