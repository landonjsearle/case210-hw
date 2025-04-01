public class Video
{
    private String _author;
    private String _title;
    private int _length;
    List<Comment> _comments;

    public Video(String author, String title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments = new List<Comment>();
    }
    public Video(String author, String title, int length, Comment comment)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments.Add(comment);
    }
    public Video(String author, String title, int length, List<Comment> comments)
    {
        _author = author;
        _title = title;
        _length = length;
        
        foreach (Comment comment in comments)
        {
            _comments.Add(comment);
        }
    }

    public int ReturnCommentNumber()
    {
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count++;
        }
        return count;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public String GetDisplay()
    {
        String display = $"{_title} by: {_author} ({_length} sec(s))\n" + 
        $"Comments: ";

        foreach(Comment comment in _comments)
        {
            display = display + "\n" + comment.DisplayComment();
        }

        return display;
    }

    public String GetAuthor()
    {
        return _author;
    }
    public String GetTitle()
    {
        return _title;
    }
    public int GetLength()
    {
        return _length;
    }
}