using System.Net;
namespace LIBRARY_TERMINAL
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public DateOnly DueDate { get; set; }
        public Book(string bookName, string author)
        {
            BookName = bookName;
            Author = author;
            Status = 0;
        }
        public List<string> SearchBookByAuthor(List<Book> book, string author)
        {
            var searchBookByAuthor = book.Where(x => x.Author == author).Select(x => x.BookName).ToList();
            return searchBookByAuthor;
        }
        public List<string> SearchBookByTitle(List<Book> book, string title)
        {
            var searchBookByTitle = book.Where(x => x.BookName == title).Select(x => x.BookName).ToList();
            return searchBookByTitle;
        }
        public void CheckOutBook(string bookTitle)
        {
            /* Book.Status 1 = checked out */
            /* Book.Status 0 = checked in */
            //Set Book.Status = 1;
            //Set DueDate + 14 days;
        }
        public void ReturnABook(string bookTitle)
        {
            //Set Book.Status = 0;
            //Delete Book.DueDate
        }
    }
}