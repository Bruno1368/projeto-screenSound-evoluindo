namespace ScreenSound.Menus;
using OpenAI_API;

using ScreenSound.Modelos;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        //cria o cliente, instanciando openai
        var client = new OpenAIAPI("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"); // nova sintaxe para instancionar objetos de classes, como parametro a api key do gpt
        //inicia um chat
        var chat = client.Chat.CreateConversation();
        // envia a mensagem
        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em um parágrafo. Adote um estilo informal.");
        //pega a resposta
        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult(); // sintaxe além da async await

        banda.Resumo = resposta;

        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}