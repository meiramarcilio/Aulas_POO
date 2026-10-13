
public class Livro
{
    public int IdLivro { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;

    internal void Cadastrar()
    {
        Console.WriteLine("Cadastrando livro...");
        Console.Write("Digite o título: ");
        Titulo = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o autor: ");
        Autor = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o ISBN: ");
        ISBN = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Livro cadastrado com sucesso!");
        Console.ReadKey();
    }
}