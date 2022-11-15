using System.Threading.Channels;
using LIBRARY_TERMINAL;

Book book = new Book();

try
{
    Console.WriteLine("Search for Book by Author or Book Title?");
    book.Author = Console.ReadLine();

}
catch (NullReferenceException)
{

}
