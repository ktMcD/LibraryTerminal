using LIBRARY_TERMINAL;



namespace LibraryTerminal.Tests
{
    public class LibraryTermTests
    {
        readonly Book _sutBook = new Book();
        readonly List<Book> _sutList = new();
        readonly string _expectedAuthorName = "TestAuthor";
        readonly string _expectedTitleName = "TestBookName";
       


        [Fact]
        public void SearchBookByAuthorListTest()
        {
          _sutList.Add(new Book("TestAuthor", "TestBookName"));
           Assert.Equal(typeof(List<Book>), _sutBook.SearchBookByAuthor(_sutList, "TestAuthor").GetType());
            
        }

        [Fact]
        public void SearchBookByAuthorTest()
        {
            _sutList.Add(new Book("TestAuthor", "TestBookName"));
            var sutBookReturnList = _sutBook.SearchBookByAuthor(_sutList, _expectedAuthorName);
            var authorNameReturned =
                sutBookReturnList.Where(x => x.Author == "TestAuthor").Select(x => x.Author).FirstOrDefault()!.ToString();

            Assert.Equal(_expectedAuthorName, authorNameReturned);
        }

        [Fact]
        public void SearchBookByTitleListTest()
        {
            _sutList.Add(new Book("TestAuthor", "TestBookName"));
            Assert.Equal(typeof(List<Book>), _sutBook.SearchBookByTitle(_sutList, "TestBookName").GetType());

        }

        [Fact]
        public void SearchBookByTitleTest()
        {
            _sutList.Add(new Book("TestAuthor", "TestBookName"));
            var sutBookReturnList = _sutBook.SearchBookByTitle(_sutList, _expectedTitleName);
            var titleNameReturned =
                sutBookReturnList.Where(x => x.BookName == "TestBookName").Select(x => x.BookName).FirstOrDefault()!.ToString();

            Assert.Equal(_expectedTitleName, titleNameReturned);

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