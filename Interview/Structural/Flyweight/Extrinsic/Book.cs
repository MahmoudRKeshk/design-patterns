using Interview.Structural.Flyweight.Intrinsic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Flyweight.Extrinsic
{
    public class Book
    {
        BookType _bookType;
        public int ShelfNumber { get; set; }
        public int RowNumber { get; set; }
        public Book(BookType bookType, int shelfNumber, int rowNumber)
        {
            _bookType = bookType;
            ShelfNumber = shelfNumber;
            RowNumber = rowNumber;
        }

        public override string ToString()
        {
            return $"{_bookType}, Shelf Number: {ShelfNumber}, Row Number: {RowNumber}";
        }
    }
}
