using System.Net;

namespace LIBRARY_TERMINAL
{
    public class Book
    {
        public Dictionary<string, string> BookList { get; set; } = new Dictionary<string, string>();

        public string BookName { get; set; }

        public string Author { get; set; }

        public Book()
        {

        }

        public Book (string author)
        {
            Author = author;
        }


        public List<string> SearchBookByAuthor(string author)
        {
            var searchAuthor = BookList.Where(x => x.Key == author).Select(x =>x.Value).ToList();
            return searchAuthor;

        }




    }
}