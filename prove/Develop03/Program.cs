using System;

public class Program
{
    public static void Main(string[] args)
    {
        string testText = "For behold this is my work and my glory to bring to pass the immortality and eternal life of man.";
        string reference = "Moses 1:39 ";
        Scripture scripture = new Scripture(testText);

        string choice = "";
            while(choice != "QUIT")
            {
                
                // 1. show scripture
                Console.Clear();
                Console.Write(reference);
                string text = scripture.ToString();
                Console.WriteLine(text);

                if (!scripture.HasVisibleWords())
                {
                    break;
                }

                Console.WriteLine("Press enter to clear some words, type QUIT to quit, or type RESTART to restart.");

                // 2. wait for input
                choice = Console.ReadLine();

                // 3. if not quit hide a word
                if (choice != "RESTART")
                {
                    scripture.RandomlyHideWord();
                }

                // 4. restore whole thing
                if (choice == "RESTART")
                {
                    scripture.MakeAllWordsVisible();
                }
            }
    }
}
