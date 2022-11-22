using System.Threading.Channels;
using LibraryTerminal;

public class Program
{
    public static void Main(string[] args)
    {
        LibraryConsole libraryVisit = new LibraryConsole();
        Console.WriteLine();
        Console.WriteLine("Library Console says, \"Initializing...\"");
        Console.WriteLine();
        libraryVisit.UseLibraryConsole();
        return;
    }
}