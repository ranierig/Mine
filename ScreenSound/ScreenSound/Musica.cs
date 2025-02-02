
class Musica {
    public Musica(string nomeMsica, Artista artista) {
        this.NomeMusica = nomeMsica;
        this.Banda = artista;
    }

    public Artista Banda { get; }
    public string NomeMusica { get; }
    public double Duracao { get; set; }
    public bool DisponivelPlano { get; set; }
    public string Descricao {
        get {
            return ($"{Banda.NomeArtista} {NomeMusica}");
        }
    }

     public string DescricaoAlternativa => $"{Banda.NomeArtista} {NomeMusica}";


    
  //  public void setDisponivel (bool disponivelPlano) { this.disponivelPlano = disponivelPlano; }
  //  public bool getDisponivel () { return disponivelPlano;}


    public void ExibirFichaTecnica() {
        //Console.WriteLine($"Nome do artista: {NomeArtista}");
        Console.WriteLine($"Nome da música: {NomeMusica}");
        Console.WriteLine($"Tempo de duração da música {Duracao}");
        if (DisponivelPlano) {
            Console.WriteLine("Disponível no plano.");
        } else {
            Console.WriteLine("Adquira o plano.");
        }
        Console.WriteLine("\n");
    }
}