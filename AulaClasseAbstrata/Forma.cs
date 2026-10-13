abstract class Forma
{
    public string Cor { get; set; } = string.Empty;

    public void Pintar()
    {
        Console.WriteLine($"Pintando a forma de cor {Cor}");
    }
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
    public abstract void Desenhar();
}