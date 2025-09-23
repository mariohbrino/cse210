using System;

class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private readonly List<Comment> _comments = [];

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lenght;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public List<Comment> GetCommentByAuthor(string author)
    {
        return _comments.FindAll(comment => comment.GetPersonName() == author);
    }

    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthSeconds()
    {
        return _lengthSeconds;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}
