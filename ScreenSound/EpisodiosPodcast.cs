class EpisodiosPodcast {
    public EpisodiosPodcast(string tituloEpisodio, int duracaoEpisodio, string resumoEpisodio, int ordem) {
        this.TituloEpisodio = tituloEpisodio;
        this.DuracaoEpisodio = duracaoEpisodio;
        this.ResumoEpisodio = resumoEpisodio;
        Ordem = ordem;
    }
    public string TituloEpisodio { get; }
    public int DuracaoEpisodio { get; }
    public string ResumoEpisodio { get; }
    public int Ordem { get; }
    public string AdicionarConvidados { get; set; }

}