using System;

namespace Sandbox
{
    class PictureBook : Book
    {
        private string _illustrator;

        public PictureBook() { }

        public PictureBook(
            string title,
            string author,
            string illustrator
        ) : base(title, author)
        {
            _illustrator = illustrator;
        }

        public string GetIllustrator()
        {
            return _illustrator;
        }

        public void SetIllustrator(string illustrator)
        {
            _illustrator = illustrator;
        }

        public override string GetBookInfo()
        {
            return $"{base.GetBookInfo()} With illustrations by {_illustrator}.";
        }
    }
}
