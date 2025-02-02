// scream sound

using System.ComponentModel;

List<String> listaBanda = new List<string>();
listaBanda.Add("Iron Maiden");
listaBanda.Add("Guns'n Roses");
listaBanda.Add("Aerosmith");
listaBanda.Add("Mettalica");
Dictionary<String,List<int>> bandasRegistradas = new Dictionary<String,List<int>>();
bandasRegistradas.Add("Iron Maiden", new List<int> { 10, 5, 3 });
bandasRegistradas.Add("Guns'n Roses", new List<int>());
bandasRegistradas.Add("Aerosmith", new List<int> { 8, 3, 4, 10 });
bandasRegistradas.Add("U2", new List<int> { 2, 6, 1, 7, 9 });


void ExibirMensagem() {
    string boasVindas;
    boasVindas = @"    
    ░██████╗███████╗░░░░░██╗░█████╗░  ██████╗░███████╗███╗░░░███╗  ██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░
    ██╔════╝██╔════╝░░░░░██║██╔══██╗  ██╔══██╗██╔════╝████╗░████║  ██║░░░██║██║████╗░██║██╔══██╗██╔══██╗
    ╚█████╗░█████╗░░░░░░░██║███████║  ██████╦╝█████╗░░██╔████╔██║  ╚██╗░██╔╝██║██╔██╗██║██║░░██║██║░░██║
    ░╚═══██╗██╔══╝░░██╗░░██║██╔══██║  ██╔══██╗██╔══╝░░██║╚██╔╝██║  ░╚████╔╝░██║██║╚████║██║░░██║██║░░██║
    ██████╔╝███████╗╚█████╔╝██║░░██║  ██████╦╝███████╗██║░╚═╝░██║  ░░╚██╔╝░░██║██║░╚███║██████╔╝╚█████╔╝
    ╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝╚═╝░░░░░╚═╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░
    ";
    Console.WriteLine(boasVindas);
}

void ExibirOpcoesMenu() {
    string lerDados;
    int opcaoEscolhida;
    Console.Clear();
    Console.WriteLine("\n 0 ou null: Sair.");
    Console.WriteLine(" 1: Registrar uma banda");
    Console.WriteLine(" 2: Exibir bandas registradas");
    Console.WriteLine(" 3: Avaliar banda");
    Console.WriteLine(" 4: Calcular média");
    Console.Write("\nDigite a sua opção: ");
    lerDados = Console.ReadLine()!;
    Console.WriteLine("\n");
    opcaoEscolhida = int.Parse(lerDados);
    switch (opcaoEscolhida) {
        case 0:
            Console.WriteLine("Volte sempre.");
        break;
        case 1:
            //Console.WriteLine("A opção escolhida foi: " + lerDados);
            //Console.WriteLine($"A opção escolhida foi: {lerDados}");
            //Console.WriteLine("A opção escolhida foi: {0}",lerDados);
            RegistrarBancda();
        break;
        case 2:
            ListarBandas();
        break;
        case 3:
            AvaliarBanda();
        break;
        case 4:
            CalcuarMedia();
        break;
        default:
            Console.WriteLine("Volte sempre.");
        break;

    }
}



void RegistrarBancda() {
    String nomeBanda;
    Console.Clear();
    tituloTela("Registrar uma banda");
    Console.WriteLine("Registrar Bandas");
    Console.Write("Digite o nome da banda: ");
    nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"O nome da banda registrada é: {nomeBanda}.");
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
}

void ListarBandas() {
    Console.Clear();
    tituloTela("Exibir bandas registradas");
    foreach (var banda in bandasRegistradas.Keys) {
        Console.Write($"{banda}: ( ");
        foreach (var avaliacao in bandasRegistradas[banda]) {
                Console.Write($"{avaliacao} ");
            }
        Console.WriteLine(")");
        }
    Console.WriteLine("\nPressione qualquer tecla para continuar.");
    Console.ReadKey();
    ExibirOpcoesMenu();
}

void AvaliarBanda() {
    string nomeBanda;
    int nota;
    Console.Clear();
    tituloTela("Avaliar banda");
    Console.Write("Entre com o nome da banda: ");
    nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda)) {
        Console.Write($"\nEntre com a avaliação da banda {nomeBanda}: ");
        nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi atribuída à banda {nomeBanda} com sucesso.");
    } else {
        Console.WriteLine("\nBanda {0} não encontrada. Favor pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        }
    ExibirOpcoesMenu();
}

void CalcuarMedia () {
    String nomeBanda;
    Console.Clear();
    tituloTela("Calcular média");
    Console.Write("Digite o nome da banda: ");
    nomeBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeBanda)) {
        Console.WriteLine($"A média da banda {nomeBanda} é {bandasRegistradas[nomeBanda].Average()}.");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
    } else {
        Console.WriteLine("\nBanda {0} não encontrada. Favor pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
    }
    ExibirOpcoesMenu();
}

void tituloTela(string tituloTela) {
    int quantidadeCaracteres;
    String criaAsterico;
    quantidadeCaracteres = tituloTela.Length;
    criaAsterico = string.Empty.PadLeft(quantidadeCaracteres,'*');
    Console.WriteLine("{0}\n{1}\n{0}\n\n", criaAsterico,tituloTela,criaAsterico);
}

ExibirMensagem();
ExibirOpcoesMenu();