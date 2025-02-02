using System.Threading.Channels;

class Episodio {
    public Episodio(int duracaoEpisodio, int ordemEpisodio, string tituloEpisodio) {
        DuracaoEpisodio = duracaoEpisodio;
        OrdemEpisodio = ordemEpisodio;
        TituloEpisodio = tituloEpisodio;
    }
    public List<string> ListaConvidados { get; set; } = new List<string>();
    public int DuracaoEpisodio { get; }
    public int OrdemEpisodio { get; }
    public string TituloEpisodio { get; }
    public string Resumo => $"Episódio -> Ordem: {OrdemEpisodio} | Título: {TituloEpisodio} | Duração: {DuracaoEpisodio} | Convidados: {string.Join(", ",ListaConvidados.OrderBy(c =>c))}";

    public void AdicionarConvidados (string nomeConvidado) {
        ListaConvidados.Add (nomeConvidado);
    }
}