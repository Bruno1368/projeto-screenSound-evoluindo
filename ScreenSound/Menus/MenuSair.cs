namespace ScreenSound.Menus;

using ScreenSound.Modelos;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        System.Console.WriteLine("Tchau Tchau :)");
    }
}