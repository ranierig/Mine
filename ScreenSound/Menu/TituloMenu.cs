namespace ScreenSound.Menu;
using ScreenSound.Modelos;
internal class TituloMenu {
    public void ExibirTituloDaOpcao(string titulo) {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public virtual void Executar(Dictionary<String,Banda> bandasRegistradas) {
        Console.Clear();


    }
}
