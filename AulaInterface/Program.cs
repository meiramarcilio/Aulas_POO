// var pagCart = new PagamentoCartao();
// pagCart.ProcessarPagamento(100);
// Console.WriteLine(pagCart.ObterComprovante());
void UsarFrota(Veiculo[] frota)
{
    foreach (var veiculo in frota)
    {
        veiculo.ExibirInfo();
        double distancia = 100; // Exemplo de distância
        double consumo = veiculo.CalcularConsumo(distancia);
        Console.WriteLine($"Consumo estimado para {distancia} km: {consumo} litros");
        veiculo.Acelerar();
    }
}
void Main()
{
    Veiculo[] frota =
    {
        new Caminhao("FH", "Volvo", 2020, "Diesel"),
        new Moto("CB500", "Honda", 2021, "Gasolina"),
        new Carro("Civic", "Honda", 2022, "Gasolina")
    };
    UsarFrota(frota);
}
Main();