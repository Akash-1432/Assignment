using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    struct Book
    {
       
         int BookId;

        public int Book_Id
        {
            get { return BookId; }
            set { BookId = value; }
        }

        public Book(int BookId)
        {
            this.BookId = BookId;
        }
        public void Display(int value)
        {
            Console.WriteLine($"Book id is:{BookId}, and book value is: {value}");
           
        }
    }

    
    internal class StructuresEg
    {
        static void Main()
        {
            Book book = new Book(098);
            book.Display(400);

            Console.Read();
        }
    }
}
