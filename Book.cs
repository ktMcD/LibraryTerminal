using System.Net;
namespace LIBRARY_TERMINAL
{
    public class Book
    {
        public DateTime today = DateTime.Today;
        public string BookName { get; set; }
        public string Author { get; set; }
        public BookStatus BookStatus { get; set; }
        public DateTime DueDate { get; set; }
        public Book(string author, string bookName)
        {
            BookName = bookName;
            Author = author;
            BookStatus = 0;
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
            
        }
        public void ReturnABook(string bookTitle)
        {
            
            BookStatus = 0;
            DueDate = DateTime.Today;
             
            //Set Book.Status = 0;
            //Delete Book.DueDate
        }
        
    }
}