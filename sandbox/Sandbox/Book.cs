using System;

namespace Sandbox
{
    class Book
    {
        private string _title = "";
        private string _author = "";

        public Book()
        {
            _title = "Unknown";
            _author = "Anonymous";
        }

        public Book(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public virtual string GetBookInfo()
        {
            return $"{_title} by {_author}.";
        }
    }
}
