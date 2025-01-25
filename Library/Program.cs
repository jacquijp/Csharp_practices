using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of books
        List<Book> books = new List<Book>
        {
            new Book("The Great Gatsby", "F. Scott Fitzgerald", false),
            new Book("1984", "George Orwell", false),
            new Book("To Kill a Mockingbird", "Harper Lee", true),
            new Book("Moby Dick", "Herman Melville", false)
        };

        // Show initial status of books
        Console.WriteLine("Initial book status:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Borrowed: {book.IsBorrowed}");
        }

        // Borrow some books
        Console.WriteLine("\nAttempting to borrow books:");
        books[0].BorrowBook(); // Borrow "The Great Gatsby"
        books[2].BorrowBook(); // Try to borrow "To Kill a Mockingbird" (already borrowed)

        // Return a book
        Console.WriteLine("\nAttempting to return books:");
        books[0].ReturnBook(); // Return "The Great Gatsby"
        books[1].ReturnBook(); // Try to return "1984" (not borrowed yet)

        // Final status of books
        Console.WriteLine("\nFinal book status:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Borrowed: {book.IsBorrowed}");
        }
    }
}
