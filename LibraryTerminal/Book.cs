using System.Net;
namespace LibraryTerminal
{
    public class Book
    {
        public DateTime today = DateTime.Today;
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public  DateTime DueDate { get; set; } = new DateTime();

        public Book()
        {

        }

        public Book(string author, string bookName)
        // at the beginning of a session, if an inventory docuement exists,
        // we'll want to read in all properties of that book when we create the object
        public Book(string bookTitle, string bookAuthor, BookStatus bookStat, DateTime dueDate)
        { 
            Title = bookTitle;
            Author = bookAuthor;
            Status = bookStat;
            DueDate = dueDate;
        }

        public Book(string bookTitle, string bookAuthor)
        {
            Title = bookTitle;
            Author = bookAuthor;
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
            
            Status = 0;
            DueDate = DateTime.Today;
        }
    }
}

