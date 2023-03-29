namespace Foundation1 {
class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<string> _commentList = new List<string>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public void TerminalDisplay()
    {
        Console.WriteLine("Video Title: " + _title);
        Console.WriteLine("Video Author: " + _author);
        Console.WriteLine("Video Length: " + _lengthInSeconds + " seconds");
        Console.WriteLine();
    }

    public void AddCommentToVideo(string comment)
    {
        _commentList.Add(comment);
    }

    public void DisplayComments()
    {
        Console.WriteLine("\tComments -- Count: " + _commentList.Count);
        Console.WriteLine("\n\t--------------------------------------------------------");
        foreach (var index in _commentList) {
            Console.WriteLine("\t" + index);
        }
        Console.WriteLine();
    }
}

}