
public class Livro
{
    public int IdLivro { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }

    internal void Cadastrar()
    {
        Console.WriteLine("Cadastrando livro...");
        Console.Write("Digite o título: ");
        Titulo = Console.ReadLine();
        Console.Write("Digite o autor: ");
        Autor = Console.ReadLine();
        Console.Write("Digite o ISBN: ");
        ISBN = Console.ReadLine();
        Console.WriteLine("Livro cadastrado com sucesso!");
        Console.ReadKey();
    }
}