
 class Album {
    List<Musica> musicas = new List<Musica>();
    public string NomeAlbum { get; set; }
    public double DuracaoAlbum => musicas.Sum(s => s.Duracao);
    
    public void InsereMusicas (Musica musica) {
        musicas.Add(musica);
    }

    public void AlbumTotal () {
        Console.WriteLine(NomeAlbum);
        Console.WriteLine($"A duração total é {DuracaoAlbum}");
        foreach (var musica in musicas) {
            Console.WriteLine(musica);
        }
    }
}