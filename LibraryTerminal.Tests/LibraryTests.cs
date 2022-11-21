using LibraryTerminal;



namespace LibraryTerminal.Tests
{
    public class LibraryTermTests
    {
   
        readonly BookInventory _sutBI = new BookInventory();
        readonly string _authorName = "Leo Tolstoy";
        readonly string _titleName = "War and Peace";
        readonly string _checkedOut = "CheckedOut";
        readonly string _onShelf = "OnShelf";

       


        [Fact]
        public void SearchBookByAuthorListTest()
        {
           Assert.Equal(typeof(List<Book>), _sutBI.SearchBookByAuthor(_authorName).GetType());
            
        }

        [Fact]
        public void SearchBookByAuthorTest()
        {
            _sutBI.PopulateBookInventory();
            var sutBookReturnList = _sutBI.SearchBookByAuthor(_authorName);
            var authorNameReturned =
                sutBookReturnList.Where(x => x.Author == _authorName).Select(x => x.Author).FirstOrDefault()!.ToString();

            Assert.Equal(_authorName, authorNameReturned);
        }

        [Fact]
        public void SearchBookByTitleListTest()
        {
            Assert.Equal(typeof(List<Book>), _sutBI.SearchBookByTitle(_titleName).GetType());

        }

        [Fact]
        public void SearchBookByTitleTest()
        {
            _sutBI.PopulateBookInventory();
            var sutBookReturnList = _sutBI.SearchBookByTitle(_titleName);
            var titleNameReturned =
                sutBookReturnList.Where(x => x.Title == _titleName).Select(x => x.Title).FirstOrDefault()!.ToString();

            Assert.Equal(_titleName, titleNameReturned);

        }


        [Fact]
        public void CheckOutBookTest()
        {
            _sutBI.PopulateBookInventory();
            _sutBI.CheckOutBook(_titleName);
            var bookStatus = _sutBI.Books.Where(x=>x.Title == _titleName).Select(x =>x.Status).FirstOrDefault().ToString();
            Assert.Equal(bookStatus, _checkedOut);

        }

        [Fact]
        public void ReturnBookTest()
        {
            _sutBI.PopulateBookInventory();
            _sutBI.ReturnABook(_titleName);
            var bookStatus = _sutBI.Books.Where(x => x.Title == _titleName).Select(x => x.Status).FirstOrDefault().ToString();
            Assert.Equal(bookStatus, _onShelf);
        }

    }

}