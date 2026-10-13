abstract class Veiculo
{
    public string Modelo { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public int Ano { get; set; }
    public string Combustivel { get; set; } = string.Empty;

    public Veiculo(string modelo, string marca, int ano, string combustivel)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
        Combustivel = combustivel;
    }

    public abstract double CalcularConsumo(double distancia);

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Combustível: {Combustivel}");
    }

    public void Acelerar()
    {
        Console.WriteLine("O veículo está acelerando.");
    }
}