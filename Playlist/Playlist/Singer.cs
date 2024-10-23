namespace Playlist;

internal class Singer
{
    private string _name;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value.Length <= 100)
                _name = value;
            else
            {
                Console.WriteLine("uzunluq 100 den cox ola bilmez");
            }
        }
    }
    private string _surname;

    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (value.Length <= 100)
                _surname = value;
            else
            {
                Console.WriteLine("uzunluq 100 den cox ola bilmez");
            }
        }
    }
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 170)
                _age = value;
            else 
            {
                Console.WriteLine("yasi 170 den cox ola bilmez");
            }
        }
    }
    public Singer(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }


}
