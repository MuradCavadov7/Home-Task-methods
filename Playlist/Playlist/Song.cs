using System.ComponentModel.Design;

namespace Playlist;

internal class Song
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

    private string _genre;

    public string Genre
    {
        get
        {
            return _genre;
        }
        set
        {
            if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Rap" || value == "Techno")
            {
                _genre = value;
            }
            else
            {
                Console.WriteLine("zehmet olmasa 'Pop','Rock','Jazz','Rap','Techno' Janrlarina uz tutun");
            }
        }
    }
    private Singer _aggregation;

    public Singer Aggregation
    {
        get
        {
            return _aggregation;
        }
        set
        {
            _aggregation = value;
        }
    }
    private double _totalRating = 0;
    private int _ratingCount = 0;



    public Song(string name, string genre, Singer aggragation)
    {
        Name = name;
        Genre = genre;
        Aggregation = aggragation;
    }

    public void AddRating(float rating)
    {
        if (Genre == "Pop" || Genre == "Rock" || Genre == "Jazz" || Genre == "Rap" || Genre == "Techno")
        {
            if (rating >= 0 && rating <= 10)
            {
                _ratingCount++;
                _totalRating += rating;
            }
            else
            {
                Console.WriteLine("Zehmet olmasa 0-10 arasinda rating daxil edin");
            }
        }
        else
        {
            Console.WriteLine("Janr duzgun secilmediyi ucun rating elave oluna bilmir");
        }
    }
    public void GetAverageRating()
    {
        if (Genre == "Pop" || Genre == "Rock" || Genre == "Jazz" || Genre == "Rap" || Genre == "Techno")
        {
            double averageRating = 0;
            averageRating = _totalRating / _ratingCount;
            Console.WriteLine($"Rating status {averageRating} from {_ratingCount} Person");
        }
        else
        {
            Console.WriteLine("Janr duzgun secilmediyi ucun rating ortalamasi hesablana bilmir");
        }
    }
}
