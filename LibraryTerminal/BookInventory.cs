namespace LIBRARY_TERMINAL
{
    public class BookInventory
    {
        public List<Book> Books = new List<Book>();

        const string bookInventoryPath = @"c:\Temp\BookInventory.txt";

        public BookInventory()
        {
            if (File.Exists(bookInventoryPath))
            {
                ReadInBookInventory();
            }
            else
            {
                PopulateBookInventory();
            }
        }

        public void PopulateBookInventory()
        {
            Books.Add(new Book("The Great Gasby", "F. Scott Fitzgerald"));
            Books.Add(new Book("War and Peace", "Leo Tolstoy"));
            Books.Add(new Book("The Odyssey", "Homer"));
            Books.Add(new Book("Hamlet", "William Shakespeare"));
            Books.Add(new Book("To Kill a Mockingbird", "Harper Lee"));
            Books.Add(new Book("The Giver", "Lois Lowry"));
            Books.Add(new Book("Help! My Teacher Hates Me!", "Meg F. Schneider"));
            Books.Add(new Book("Dark Psychology", "Ryan Watson"));
            Books.Add(new Book("Tequila Mockingbird", "Cpt. Cuervo Audobon"));
            Books.Add(new Book("The Alchemist", "Paulo Coelho"));
            Books.Add(new Book("The 48 Laws of Power", "Robert Green"));
            Books.Add(new Book("The Only Thing Mice are Good Fur is Nomnom", "Snowball"));
            Books.Add(new Book("1984", "George Orwell"));
            Books.Add(new Book("Harry Potter and the Philospher's Stone", "J.K. Rowling"));
            Books.Add(new Book("The Lord of the Rings", "J.R.R. Tolkien"));
        }

        public void DisplayBookList()
        {
            foreach (Book book in Books)
            {
                if (book.Status == BookStatus.OnShelf)
                {
                    Console.WriteLine($"{book.Title,-45} --- {book.Author,-25} --- {"Available",10}");
                }
                else
                {
                    Console.WriteLine($"{book.Title,-45} --- {book.Author,-25} --- Due: {book.DueDate:,10:d}");
                }
            }
        }

        public void RecordBookInventory()
        {
            StreamWriter bookInventoryRecorder = new StreamWriter(bookInventoryPath, false);
            foreach (Book book in Books)
            {
                if (book.Status == BookStatus.OnShelf)
                {
                    bookInventoryRecorder.WriteLine($"{book.Title,-45}|{book.Author,-25}|{"Available",10}");
                }
                else
                {
                    bookInventoryRecorder.WriteLine($"{book.Title,-45}|{book.Author,-25}|{book.DueDate:,10:d}");
                }
            }
            bookInventoryRecorder.Flush();
            bookInventoryRecorder.Close();
        }

        public void ReadInBookInventory()
        {
            /*
            StreamReader reader = new StreamReader(bookFilePath);
            while (true)
            {
                string line = reader.ReadLine();
                // Leave the loop if the end of file is reached
                if (line == null)
                {
                    break;
                }
            }
            */
        }
    }
}
