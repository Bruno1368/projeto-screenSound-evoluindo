namespace ScreenSound.Menus;

using ScreenSound.Modelos;

internal class MenuSair : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        System.Console.WriteLine("Tchau Tchau :)");
    }
}