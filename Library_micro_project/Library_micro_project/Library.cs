using Newtonsoft.Json;

namespace Library_micro_project;

internal class Library 
{
    private static int counter;
    public int Id { get; }
    public string Name { get; set; }
    public string Path { get; set; }

    private List<Book>books = [];
    public Library(string name,string path)
    {
        Id=++counter;
        Name = name;
        Path = path;
    }

    public void AddBook(Book book)
    {
        books = Read(Path);
        books.Add(book);
        Writer(books);
    }

    public Book GetBookById(int id)
    {   books = Read(Path);
        Book? book = books.Find(b => b.Id == id);
        if (book == null)
        {
            throw new ArgumentNullException($"Daxilin edilən Id-ə({id}) sahib kitab catalogda yer almir");
        }
        Writer(books);
        return book;
    }
    public void RemoveBook(int id)
    {
        books = Read(Path);
        Book? book =books.Find(b => b.Id == id);
        if (book == null)
        {
            throw new ArgumentNullException($"Daxilin edilən Id-ə({id}) sahib kitab catalogda yer almir");
        }
        books.Remove(book);
        Writer(books);
    }

    public void Writer(List<Book> text)
    {
        using StreamWriter sw = new StreamWriter(Path,false);
        sw.WriteLine(JsonConvert.SerializeObject(text));
    }
    public List<Book> Read(string path)
    {
        using StreamReader sr = new StreamReader(path);
         List<Book>? books = JsonConvert.DeserializeObject<List<Book>>(sr.ReadToEnd());
        return books ??= new List<Book>();
    }
}
