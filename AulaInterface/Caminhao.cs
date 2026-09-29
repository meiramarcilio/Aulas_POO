class Caminhao : Veiculo
{
    public Caminhao(string modelo, string marca, int ano, string combustivel) : base(modelo, marca, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 6;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Tipo: Caminhão");
        base.ExibirInfo();
    }
}