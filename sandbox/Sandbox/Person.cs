using System;

namespace Sandbox
{
    public class Person(string name)
    {
        private string _name = name;

        public string GetName()
        {
            return _name;
        }
    }
}
