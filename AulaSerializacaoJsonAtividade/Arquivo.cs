public abstract class Arquivo
{
    public string Caminho { get; set; } = string.Empty;

    public abstract string Escrever();

    public abstract void Ler();
}