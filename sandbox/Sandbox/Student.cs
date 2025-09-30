using System;

namespace Sandbox
{
    public class Student(string name, string number) : Person(name)
    {
        private string _number = number;

        public string GetNumber()
        {
            return _number;
        }
    }
}
