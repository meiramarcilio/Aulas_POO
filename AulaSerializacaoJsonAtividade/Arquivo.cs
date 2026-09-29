public abstract class Arquivo
{
    public string Caminho { get; set; }

    public abstract string Escrever();

    public abstract void Ler();
}