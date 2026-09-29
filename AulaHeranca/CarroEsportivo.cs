public class CarroEsportivo : Carro
{
    private bool turbo;
    public CarroEsportivo(string marca, string modelo, int numeroDePortas) : base(marca, modelo, numeroDePortas)
    {
        this.turbo = true;
    }
}