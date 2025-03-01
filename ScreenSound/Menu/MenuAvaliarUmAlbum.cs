using ScreenSound.Menu;
using ScreenSound.Modelos;
internal class MenuAvaliarUmAlbum : TituloMenu {
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) {
        base.Executar(bandasRegistradas);
        Console.Clear();
        Console.WriteLine("Digite o nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        
        if (bandasRegistradas.ContainsKey(nomeBanda)) {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.WriteLine("Digite o nome do album que deseja avaliar: ");
            string nomeAlbum = Console.ReadLine()!;

            if (nomeBanda.Albuns.Any(a => a.Nome.Equals(nomeAlbum))) {

            }
            }
        }
}