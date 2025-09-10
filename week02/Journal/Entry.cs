using System;
using System.Text.Json.Serialization;

class Entry
{
    [JsonPropertyName("prompt")]
    public string _prompt { get; set; }
    [JsonPropertyName("response")]
    public string _response { get; set; }
    [JsonPropertyName("create_at")]
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
