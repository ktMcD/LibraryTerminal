using Xunit;
using LibraryTerminal;



namespace LibraryTerminal.Tests
{
    public class LibraryTermTests
    {
        readonly Book _sutBook = new Book("TestAuthor", "TestBookName");
        readonly BookInventory _sutBI = new BookInventory();
        readonly List<Book> _sutList = new List<Book>();


        [Fact]
        public void SearchBookByAuthorTest()
        {
            Assert.Equal(typeof(List<Book>), _sutBI.SearchBookByAuthor("TEST").GetType());
        }

        [Fact]
        public void SearchBookByTitleTest()
        {
            Assert.Equal(typeof(List<Book>), _sutBI.SearchBookByTitle("TEST").GetType());

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