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
        }
    }
    public Singer(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }


}
