using Interview.Structural.Flyweight.Intrinsic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Flyweight
{
    public class BookFactory
    {
        private readonly Dictionary<string, BookType> _bookTypes = new Dictionary<string, BookType>();
        public BookType GetBookType(string title, string author, string genre, string isbn, int publicationYear, int numberOfPages)
        {
            string key = $"{title}-{author}-{isbn}-{genre}-{publicationYear}-{numberOfPages}";
            if (!_bookTypes.ContainsKey(key))
            {
                var bookType = new BookType(title, author, genre, isbn, publicationYear, numberOfPages);
                _bookTypes[key] = bookType;
            }
            return _bookTypes[key];
        }
    }
}
