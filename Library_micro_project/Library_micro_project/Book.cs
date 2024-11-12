namespace Library_micro_project;
abstract class Idinherit
{
    private static int counter;
    public int Id { get; set; }
    protected Idinherit()
    {

    }
    protected Idinherit(string text)
    {
        Id = ++counter;
    }
}
internal class Book:Idinherit
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public double Price { get; set; }

    public Book(string name,string authorName,double price):base("abc")
    {
        Name = name;
        AuthorName = authorName;
        Price = price;
    }
    public Book()
    {
        
    }
    public void ShowInfo()
    {
        Console.WriteLine($"ID:{Id} Name:{Name} Author Name:{AuthorName} Price:{Price}");
    }
}
