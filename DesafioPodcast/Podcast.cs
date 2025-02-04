class Podcast {
    public Podcast(string hostPodcast, string nomePodcast) {
        HostPodcast = hostPodcast;
        NomePodcast = nomePodcast;
    }
    List<Episodio> episodios = new();
    public string HostPodcast { get; }
    public string NomePodcast { get; }
    public int TotalEpisodios => episodios.Count;
    public void AdicionarEpisodio (Episodio episodio) {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes() {
        Console.WriteLine($"Host do Podcast: {HostPodcast} | Nome do Podcast {NomePodcast}");
        Console.WriteLine("Episodios: ");
        foreach (Episodio episodio in episodios.OrderBy(c => c.OrdemEpisodio)) {
            Console.WriteLine(episodio.Resumo);
        }
    }
}