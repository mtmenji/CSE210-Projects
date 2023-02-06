using System;

class Journal
{
    public string divider = "------------------";
    public List<Entry> journalEntries = new List<Entry>();
    public Journal()
    {
    }
    public void Load()
    {
        Console.WriteLine("Which Journal would you like to load?");
        string journalNameLoad = Console.ReadLine();
        journalNameLoad += ".txt";

        string[] lines = System.IO.File.ReadAllLines(journalNameLoad);

        foreach (string line in lines)
        {
            string[] entry = line.Split("\n");
            Console.WriteLine(line);
        }

        Console.WriteLine();
    }
    public void Save()
    {
        // Ask user to enter a journal name. Convert to .txt file.
        Console.WriteLine("Enter the name for a new/existing Journal?");
        string journalNameSave = Console.ReadLine();
        journalNameSave += ".txt";

        // Write out journal entries into a text file.
        TextWriter tw = new StreamWriter(journalNameSave, true);
        foreach (Entry entry in journalEntries)
        {
           tw.WriteLine($"{entry.date} --- {entry.prompt}\n{entry.memo}");
        }
        tw.Close();
        Console.WriteLine("File saved.");
        
        // Clear the journal array in case the user wants to create additional entries.
        journalEntries.Clear();
    }
    public void Display()
    {
        foreach (Entry entry in journalEntries)
        {
           Console.WriteLine($"{entry.date} --- {entry.prompt}\n{entry.memo}");
        }
        Console.WriteLine();
    }
}