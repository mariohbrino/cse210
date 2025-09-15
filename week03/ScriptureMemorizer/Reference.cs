using System;
using System.Collections.Generic;
using System.Linq;

class Reference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly List<int> _verses = new List<int>();

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses.Add(verse);
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verses.Add(startVerse);
        _verses.Add(endVerse);
    }

    public string GetVerses()
    {
        if (_verses.Count == 1)
            return $"{_verses[0]}";
        return $"{_verses[0]}-{_verses[1]}";
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{GetVerses()}";
    }
}
