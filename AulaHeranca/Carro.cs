public class Carro: Veiculo
{
    protected int numeroDePortas;
    public Carro(string marca, string modelo, int numeroDePortas) : base(marca, modelo)
    {
        this.numeroDePortas = numeroDePortas;
    }
}