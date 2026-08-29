using System;

class Book
{
    public string title;
    public int pages;
}

class Program
{
    static void Main()
    {
        Book book = new Book();
        book.title = "Clean Code";
        book.pages = 464;

        object obj = book;
        Console.WriteLine(obj);
    }
}
//1st answer