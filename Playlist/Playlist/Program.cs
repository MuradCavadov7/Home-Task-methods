namespace Playlist;

internal class Program
{
    static void Main(string[] args)
    {
        Singer paster = new Singer("Paster", "Blessed", 35);
        Song song = new Song("Zengezur", "Rap", paster);
        song.AddRating(9.3f);
        song.AddRating(8.4f);
        song.AddRating(9.5f);
        song.GetAverageRating();
    }
}

