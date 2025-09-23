using System;

class Comment
{
    private string _personName;
    private string _message;
    public Comment(string person, string message)
    {
        _personName = person;
        _message = message;
    }

    public string GetPersonName()
    {
        return _personName;
    }

    public string GetMessage()
    {
        return _message;
    }
}
