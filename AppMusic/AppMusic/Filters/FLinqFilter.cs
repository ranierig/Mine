using AppMusic.Model;
namespace AppMusic.Filters; 

internal class FLinqFilter {
    public static void ShowGenres (List<MListMusics> mList) {
        var genres = mList.Select(genre => genre.Genre).Distinct().ToList();
        genres.ForEach(genres =>  Console.WriteLine(genres));
    }
    public static void ShowOrderByArtists(List<MListMusics> mList) {
        var listArtists = mList.OrderBy(artist => artist.Artist).Select(artist => artist.Artist).Distinct().ToList();
        listArtists.ForEach(artist => Console.WriteLine(artist)) ;
    }
    public static void ShowArtistsGenre (List<MListMusics> mList, string genre) {
        var listArtists = mList.Where(artist => artist.Genre.ToUpper().Contains(genre.ToUpper())).Select(artist => artist.Artist).ToList();
        listArtists.ForEach(artists => Console.WriteLine(artists));
    }
    public static void ShowMusicsArtists (List<MListMusics> mList, string artist) {
        var listMusics = mList.Where(music => music.Artist.ToUpper().Contains(artist.ToUpper())).Select(music => music.Music).ToList();
        listMusics.ForEach(music => Console.WriteLine(music));
    }
}
