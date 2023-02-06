using System;

class Entry
{
    public string prompt;
    public string memo;
    public string date;
    public void EntryCreator()
    {
        // Display prompt and receive user input as userEntry.
        PromptGenerator promptGenerator = new PromptGenerator();
        prompt = promptGenerator.GeneratePrompt();
        Console.WriteLine(prompt);
        
        // Combine prompt, memo, and date into an array.
        memo = Console.ReadLine();
        date = DateTime.Now.ToShortDateString();
    }

}