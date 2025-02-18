﻿namespace ScreenSound.Modelos; 
class Banda : IAvaliavel
{
    
    public Banda(string nome) {
        Nome = nome;
    }
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public string Nome { get; }
    public double Media {
        get {
            if (notas.Count > 0) {
                return notas.Average(a => a.Nota);
            } else {
                return 0;
            }
        }
    }
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}