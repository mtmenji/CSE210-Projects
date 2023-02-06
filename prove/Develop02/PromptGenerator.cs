using System;

class PromptGenerator
{
    public string GeneratePrompt()
    {
        //List of prompts.
        string[] promptList = {
        "What was your favorite thing that happened today?",
        "What could you have done better today?", 
        "What made you smile today?",
        "What's the funniest thing you witnessed today?",
        "Who made your day today?",
        "What insights did you gain from you scripture study today?"
        };

        //Selecting a random prompt from the list above.
        Random rnd = new Random();
        int index  = rnd.Next(0, promptList.Length);
        string selectedPrompt = promptList[index];

        return selectedPrompt;
    }
}