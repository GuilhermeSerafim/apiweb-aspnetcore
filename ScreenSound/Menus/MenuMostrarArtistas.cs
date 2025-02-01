using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarArtistas : Menu
{
    // Aparentemente a chave é a string, e o valor é o objeto que contém os dados do Artista
    public override void Executar(Dictionary<string, Artista> musicasRegistradas)
    {
        base.Executar(musicasRegistradas);
        ExibirTituloDaOpcao("Exibindo todos os artistas registradas na nossa aplicação");

        foreach (string artista in musicasRegistradas.Keys)
        {
            Console.WriteLine($"Artista: {artista}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
