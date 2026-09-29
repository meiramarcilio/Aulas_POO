class Circulo : Forma
{
    public double Raio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }

    public override void Desenhar()
    {
        Console.WriteLine($"Desenhando um círculo com raio {Raio}");
    }
}