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
        //1st answer
        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());
        //2nd amswer
        int pages = 464;
        Console.WriteLine(pages);
        //3rd answer
        