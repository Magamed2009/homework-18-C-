public class Book
{
    public string Title;
    public string Author;
    public int Year;
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void Getinfo()
    {
        System.Console.WriteLine($"Title : {Title}\nAuthor : {Author}\nYear : {Year}");
    }
    public bool IsPublishedRecently()
    {
        if(Year > 2010) {return true;}
        else {return false;}
    }
}