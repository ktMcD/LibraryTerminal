using System.Net;
namespace LIBRARY_TERMINAL
{
    public class Book
    {
        public DateTime today = DateTime.Today;
        public string BookName { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public  DateTime DueDate { get; set; } = new DateTime();
        public Book(string author, string bookName)
        {
            BookName = bookName;
            Author = author;
            Status = 0;

        }

        public List<Book> SearchBookByAuthor(List<Book> book, string author)
        {
            var searchBookByAuthor = book.Where(x => x.Author.Contains(author, StringComparison.InvariantCultureIgnoreCase)).Select(x => x).ToList();
            return searchBookByAuthor;

        }

        public List<Book> SearchBookByTitle(List<Book> book, string title)
        {
            var searchBookByTitle = book.Where(x => x.BookName.Contains(title, StringComparison.InvariantCultureIgnoreCase)).Select(x => x).ToList();


            return searchBookByTitle;

        }
        public void CheckOutBook(List<Book> book, string bookTitle)
        {
            
            this.Status = (BookStatus)1;
            this.DueDate = today.AddDays(14);

        }
		
		public void ReturnABook(string bookTitle)
        {
            
            BookStatus = 0;
            DueDate = DateTime.Today;
             
        }
    }
}

