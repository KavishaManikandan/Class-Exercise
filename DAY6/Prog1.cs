using System;
using System.Collections.Generic;

class Book
{
    // Define properties
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    // Define constructor
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}

class Library
{
    // Define collection to store books
    private List<Book> books = new List<Book>();

    // Add method to add a book
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    // Add method to remove a book by ISBN
    public void RemoveBook(string isbn)
    {
        Book bookToRemove = books.Find(book => book.ISBN == isbn);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    // Add method to list all books
    public void ListBooks()
    {
        Console.WriteLine("Listing all books:");
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Prompt for book details and add book
                    Console.WriteLine("Enter book title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter book author:");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter book ISBN:");
                    string isbn = Console.ReadLine();
                    Book book = new Book(title, author, isbn);
                    library.AddBook(book);
                    break;
                case 2:
                    // Prompt for ISBN and remove book
                    Console.WriteLine("Enter book ISBN to remove:");
                    string isbnToRemove = Console.ReadLine();
                    library.RemoveBook(isbnToRemove);
                    break;
                case 3:
                    // List all books
                    library.ListBooks();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}