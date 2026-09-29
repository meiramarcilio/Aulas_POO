class Carro : Veiculo, ISeguranca, IManutencao
{
    public Carro(string modelo, string marca, int ano, string combustivel) : base(modelo, marca, ano, combustivel)
    {
    }

    public void AtivarAlarme()
    {
        Console.WriteLine("Alarme ativado.");
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 12;
    }

    public override void ExibirInfo()   
    {
        Console.WriteLine("Tipo: Carro");
        base.ExibirInfo();
    }

    public void RealizarRevisao()
    {
        Console.WriteLine("Revisão realizada.");
    }

    public void TravarPortas()
    {
        Console.WriteLine("Portas travadas.");
    }

    public void TrocarOleo()
    {
        Console.WriteLine("Óleo trocado.");
    }
}