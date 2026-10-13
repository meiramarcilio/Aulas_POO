
public class Usuario
{
    public int IdUsuario { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;

    internal void Cadastrar()
    {
        Console.WriteLine("Cadastrando usuário...");
        Console.Write("Digite o nome: ");
        Nome = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite o email: ");
        Email = Console.ReadLine() ?? string.Empty;
        Console.Write("Digite a senha: ");
        Senha = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Usuário cadastrado com sucesso!");
        Console.ReadKey();
    }
}