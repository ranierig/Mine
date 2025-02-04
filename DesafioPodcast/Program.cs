
Episodio episodioa = new(42, 2, "Segundo episodio");
episodioa.AdicionarConvidados("Sergio");
episodioa.AdicionarConvidados("Amateus");
episodioa.AdicionarConvidados("Bruno");

Episodio episodiob = new(40, 1, "Primeiro episodio");
episodiob.AdicionarConvidados("Sergio");
episodiob.AdicionarConvidados("Amateus");

Console.WriteLine(episodioa.Resumo);
Console.WriteLine(episodiob.Resumo);

Podcast meuPodcast = new("Hostmeu", "Podcast do meu");
meuPodcast.AdicionarEpisodio(episodioa);
meuPodcast.AdicionarEpisodio(episodiob);

Console.WriteLine("\n---------------------------------\n\n");
meuPodcast.ExibirDetalhes();