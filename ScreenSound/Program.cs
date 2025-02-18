using ScreenSound.Menu;
using ScreenSound.Modelos;

Dictionary<string, Banda> bandasRegistradas = new();

Banda Ira = new("Ira");
Ira.AdicionarNota(new Avaliacao(8));
Ira.AdicionarNota(new Avaliacao(5));
Ira.AdicionarNota(new Avaliacao(9));

Banda IronMaiden = new("Iron Maiden");
IronMaiden.AdicionarNota(new Avaliacao(10));
IronMaiden.AdicionarNota(new Avaliacao(9));
IronMaiden.AdicionarNota(new Avaliacao(10));

bandasRegistradas.Add(IronMaiden.Nome,IronMaiden);
bandasRegistradas.Add(Ira.Nome,Ira);

Dictionary<int, TituloMenu> menu = new();
menu.Add(1, new MenuRegistrarUmaBanda());
menu.Add(2, new MenuRegistrarAlbum());
menu.Add(3, new MenuMostrarBandasRegistradas());
menu.Add(4, new MenuAvaliarUmaBanda());
menu.Add(5, new MenuExibirDetalhes());

ExibirOpcoesDoMenu();
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica != 0) { 
        if (menu.ContainsKey(opcaoEscolhidaNumerica)) {
            TituloMenu titulo = menu[opcaoEscolhidaNumerica];
            titulo.Executar(bandasRegistradas);
        } else {
        Console.WriteLine("Opção errada, favor informar de acordo com o menu.");
        }
        ExibirOpcoesDoMenu();
    } else {
        Console.WriteLine("Volte sempre.");
    }
}