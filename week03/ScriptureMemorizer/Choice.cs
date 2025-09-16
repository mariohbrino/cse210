using System;

class Choice(int index, string name)
{
    private int _index { get; set; } = index;
    private string _name { get; set; } = name;

    public void Deconstruct(out int index, out string name)
    {
        index = _index;
        name = _name;
    }
}
