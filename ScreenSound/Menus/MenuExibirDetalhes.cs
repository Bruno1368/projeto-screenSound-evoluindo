using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu //sintaxe em csharp para dizer que a classe menuavaliarbanda herda de menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)// palavra reservada override para dizer que vai ser sobrescrito
    {
       base.Executar(bandasRegistradas);//palavra reservada base para dizer que quer reutilizar o que está no metodo executar da classe mae
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();


        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }

}
