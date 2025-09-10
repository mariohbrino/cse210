using System;

class Entry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _createdAt { get; set; }

    public override string ToString()
    {
        return string.Join("|", _createdAt, _response, _prompt);
    }

    public void Deconstruct(out string prompt, out string response, out string createdAt)
    {
        prompt = _prompt;
        response = _response;
        createdAt = _createdAt;
    }
}
