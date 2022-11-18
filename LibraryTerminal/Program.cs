 using System.Threading.Channels;
using LIBRARY_TERMINAL;

internal class Program
{
    BookInventory library = new BookInventory();
    private static void Main(string[] args)
    {
        Program testLibrary = new Program();
        // call LibraryVisit from here and let LibraryVisit drive the whole thing
        testLibrary.TryMe();
    }

    public void TryMe()
    {
        library.DisplayBookList();
    }
}

