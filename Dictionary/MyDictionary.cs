using System;
using System.Collections.Generic;

class Library
{
    private Dictionary<string, string> books = new Dictionary<string, string>();

    public void AddBook(string isbn, string title)
    {
        if (!books.ContainsKey(isbn))
        {
            books.Add(isbn, title);
            Console.WriteLine($"{title} eklendi.");
        }
        else
        {
            Console.WriteLine("Bu ISBN numarasına sahip bir kitap zaten var.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("\nKütüphanedeki kitaplar:");
        foreach (var book in books)
        {
            Console.WriteLine($"ISBN: {book.Key}, Kitap Adı: {book.Value}");
        }
    }

    public void RemoveBook(string isbn)
    {
        if (books.Remove(isbn))
        {
            Console.WriteLine("Kitap başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Kitap bulunamadı.");
        }
    }
}