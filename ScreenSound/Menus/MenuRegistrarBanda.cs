namespace ScreenSound.Menus;
using OpenAI_API;

using ScreenSound.Modelos;

internal class MenuRegistrarBanda : Menu
{
    public override async void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        var client = new OpenAIAPI("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"); // nova sintaxe para instancionar objetos de classes, como parametro a api key do gpt

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage("Resuma a banda ira! em um parágrafo. Adote um estilo informal.");

        string resposta = await chat.GetResponseFromChatbotAsync();

        System.Console.WriteLine(resposta);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();

    }
}