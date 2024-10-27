using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddBook("978-0131101630", "The C Programming Language");
        library.AddBook("978-0132350884", "Clean Code");
        library.AddBook("978-0201616224", "The Pragmatic Programmer");

        library.DisplayBooks();

        library.RemoveBook("978-0131101630");

        library.DisplayBooks();

        Console.ReadKey();
    }
}
