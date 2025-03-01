using System.Text.Json;
using AppMusic.Model;
using (HttpClient httpClient = new() ) {
    try {
        string responseList = await httpClient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<MListMusics>>(responseList)!;
        //Console.WriteLine(responseList);
        musics[0].ShowMusics();
    } catch (Exception ex) {
        Console.WriteLine("Erro ao chamar a API de listas de músicas.");    
    }


}