namespace ScreenSound.Modelos;

internal class Avaliacao 
{
    public Avaliacao(int nota)
    {
        if(nota <= 10 && nota > 0)
        {
            Nota = nota;
        } else 
        {
            System.Console.WriteLine($"A nota {nota} não é um número válido, por favor insira uma nota de 1 a 10");
        }
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}