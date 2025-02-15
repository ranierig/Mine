﻿namespace ScreenSound.Menu;
using ScreenSound.Modelos;
internal class MenuMostrarBandasRegistradas : TituloMenu {
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) {
        base.Executar(bandasRegistradas);
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys) {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}