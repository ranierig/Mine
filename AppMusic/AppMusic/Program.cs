using System.Text.Json;
using AppMusic.Filters;
using AppMusic.Model;

using (HttpClient httpClient = new() ) {
    try {
        string responseList = await httpClient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<MListMusics>>(responseList)!;
        //Console.WriteLine(responseList);
        //musics[0].ShowMusics();
        //FLinqFilter.ShowGenres(musics);
        //FLinqFilter.ShowOrderByArtists(musics);
        //FLinqFilter.ShowArtistsGenre(musics,"Rock");
        //FLinqFilter.ShowMusicsArtists(musics, "U2");
        MusicasPreferidas musicasRaniss = new("ranis");
        musicasRaniss.AddMusicList(musics[2]);
        musicasRaniss.AddMusicList(musics[3]);
        musicasRaniss.AddMusicList(musics[235]);

        string requestList = JsonSerializer.Serialize(musicasRaniss);
        string caminhoArquivo = "c:\\temp\\arquivo.txt";
        using (StreamWriter writer = new StreamWriter(caminhoArquivo)) {
            writer.WriteLine(requestList);
        }

    } catch (Exception ex) {
        Console.WriteLine($"Erro ao chamar a API de listas de músicas: {ex}");    
    }

}

