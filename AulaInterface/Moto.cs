class Moto : Veiculo
{
    public Moto(string modelo, string marca, int ano, string combustivel) : base(modelo, marca, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 35;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Tipo: Moto");
        base.ExibirInfo();        
    }
}