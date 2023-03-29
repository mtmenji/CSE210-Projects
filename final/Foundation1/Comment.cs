namespace Foundation1 {

public class Comment
{
    private string _commentor;
    private string _commentText;

    public Comment(string commentor, string commentText)
    {
        _commentor = commentor;
        _commentText = commentText;
    }

    public string GetFullComment() {
        string _fullComment = _commentor + ": " + _commentText;
        return _fullComment;
    }
}

}