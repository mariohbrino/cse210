using System;

namespace Mindfulness
{
    class Ponder
    {
        private string _message;
        private bool _used = false;

        public Ponder(string message)
        {
            _message = message;
        }

        public string GetMessage() => _message;
        public bool IsUsed() => _used;
        public void MarkAsUsed() => _used = true;
    }
}