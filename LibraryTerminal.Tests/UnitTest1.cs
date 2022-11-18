using Xunit;
using LIBRARY_TERMINAL;



namespace LibraryTerminal.Tests
{
    public class LibraryTermTests
    {
        readonly Book _sutBook = new Book("TestAuthor", "TestBookName");
        readonly List<Book> _sutList = new List<Book>();



        [Fact]
        public void SearchBookByAuthorTest()
        {
            Assert.Equal(typeof(List<Book>), _sutBook.SearchBookByAuthor(_sutList, "TEST").GetType());
        }

        [Fact]
        public void SearchBookByTitleTest()
        {
            Assert.Equal(typeof(List<Book>), _sutBook.SearchBookByTitle(_sutList, "TEST").GetType());

        }

        [Fact]
        public void CheckOutBookTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void ReturnBookTest()
        {
            Assert.True(true);
        }

    }

}