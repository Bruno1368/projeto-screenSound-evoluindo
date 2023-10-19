namespace ScreenSound.Modelos;
//sintaxe da interface
internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}