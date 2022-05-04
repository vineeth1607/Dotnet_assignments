using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAssignment
{
    struct Book
    {

        int Book_Id;

        public int Book_ID
        {
            get { return Book_Id; }
            set { Book_Id = value; }
        }

        public Book (int Book_id)
        {
            this.Book_Id = Book_id;
        }
        public void Display(int value)
        {
            Console.WriteLine($"Book_ID : {Book_Id} and Price of the book : {value}");

        }
    }


    class Structure
    {
        static void Main()
        {
            Book book = new Book(76581);
            book.Display(399);

            Console.ReadLine();
        }
    }
}