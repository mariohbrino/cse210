using System;

class Choise
{
    public int _index { get; set; }
    public string _name { get; set; }

    public void Deconstruct(out int index, out string name)
    {
        index = _index;
        name = _name;
    }
}