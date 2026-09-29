void Main()
{
    Forma[] formas =
    {
        new Retangulo { Largura = 10, Altura = 5, Cor = "Azul" },
        new Circulo { Raio = 7, Cor = "Vermelho" },
        new Circulo { Raio = 3, Cor = "Verde" },
        new Retangulo { Largura = 4, Altura = 8, Cor = "Amarelo" }
    };
    foreach(var forma in formas)
    {
        forma.Pintar();
        Console.WriteLine($"Área: {forma.CalcularArea()}");
    }
}

Main();