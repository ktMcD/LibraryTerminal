﻿using System.Net;
namespace LIBRARY_TERMINAL
{
    public class Book
    {
        public DateTime today = DateTime.Today;
        public string BookName { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public  DateTime DueDate { get; set; } = new DateTime();
        public Book(string author, string bookName)
        {
            BookName = bookName;
            Author = author;
            Status = 0;

        }
        public List<string> SearchBookByAuthor(List<Book> book, string author)
        {
            var searchBookByAuthor = book.Where(x => x.Author == author).Select(x => x.BookName).ToList();
            return searchBookByAuthor;
        }
        public List<string> SearchBookByTitle(List<Book> book, string title)
        {
            var searchBookByTitle = book.Where(x => x.BookName == title).Select(x => x.BookName).ToList();
            return searchBookByTitle;
        }
        public void CheckOutBook(List<Book> book, string bookTitle)
        {
            
            this.Status = (BookStatus)1;
            this.DueDate = today.AddDays(14);

        }
        public void ReturnABook(string bookTitle)
        {
            //Set Book.Status = 0;
            //Delete Book.DueDate
        }
    }
}