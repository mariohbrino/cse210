using System;


namespace EternalQuest
{
    class Choice
    {
        private int _index { get; set; }
        private string _name { get; set; }
        private Action _callback { get; set; } = null;
        private bool _quit { get; set; } = false;

        public Choice() { }

        public Choice(int index, string name)
        {
            _index = index;
            _name = name;
        }

        public Choice(int index, string name, bool quit)
        {
            _index = index;
            _name = name;
            _quit = quit;
        }

        public Choice(int index, string name, Action callback)
        {
            _index = index;
            _name = name;
            _callback = callback;
        }

        public Choice(int index, string name, Action callback, bool quit)
        {
            _index = index;
            _name = name;
            _callback = callback;
            _quit = quit;
        }

        public int GetIndex() => _index;
        public string GetName() => _name;
        public bool GetQuit() => _quit;

        public void ExecuteCallback()
        {
            if (_callback == null)
            {
                Console.WriteLine("Callback not defined, please check your application");
            }
            else
            {
                _callback.Invoke();
            }
        }

        public void Deconstruct(out int index, out string name)
        {
            index = _index;
            name = _name;
        }
    }
}
