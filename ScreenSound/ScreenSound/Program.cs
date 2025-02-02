

using System.Reflection;

Artista artista = new Artista("Iron Maiden");


Musica musica1 = new Musica("Fear of the Dark", artista) {
    Duracao = 7,
    DisponivelPlano = true,
};

Console.WriteLine(musica1.Descricao);
Console.WriteLine(musica1.DescricaoAlternativa);
// musica1.setDisponivel(true);

Musica musica2 = new Musica("Wasting Love", artista) {
    Duracao = 7,
    DisponivelPlano = false,
};
// musica2.setDisponivel(false);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Console.WriteLine("----------------------------------");

Album album = new Album();
album.NomeAlbum = "Album esqueci";
album.InsereMusicas(musica1);
album.InsereMusicas(musica2);

album.AlbumTotal();







