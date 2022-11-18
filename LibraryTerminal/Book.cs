using System.Net;
namespace LIBRARY_TERMINAL
{
    public class Book
    {
        public DateTime today = DateTime.Today;
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public  DateTime DueDate { get; set; } = new DateTime();
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
            var searchBookByTitle = book.Where(x => x.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase)).Select(x => x).ToList();


            return searchBookByTitle;

        }
        public void CheckOutBook(List<Book> book, string bookTitle)
        {
            this.Status = (BookStatus)1;
            this.DueDate = today.AddDays(14);
        }
		
		public void ReturnABook(string bookTitle)
        {
            // katie updated this to get it to compile. We use the variable name for BookStatus here. :)
            // should we use the same pattern that Shan used in CheckOutBook?
            this.Status = (BookStatus)0; 
            DueDate = DateTime.Today;
        }
    }
}

