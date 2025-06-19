using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Flyweight.Intrinsic
{
    public class BookType
    {
        private readonly string _title;
        private readonly string _author;
        private readonly string _genre;
        private readonly string _isbn;
        private readonly int _publicationYear;
        private readonly int _numberOfPages;
        public BookType(string title, string author, string genre, string isbn, int publicationYear, int numberOfPages)
        {
            _title = title;
            _author = author;
            _genre = genre;
            _isbn = isbn;
            _publicationYear = publicationYear;
            _numberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            return $"{this._title} by {this._author}";
        }
    }
}
