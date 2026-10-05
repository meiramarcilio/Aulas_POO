
public class Usuario
{
    public int IdUsuario { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    internal void Cadastrar()
    {
        Console.WriteLine("Cadastrando usuário...");
        Console.Write("Digite o nome: ");
        Nome = Console.ReadLine();
        Console.Write("Digite o email: ");
        Email = Console.ReadLine();
        Console.Write("Digite a senha: ");
        Senha = Console.ReadLine();
        Console.WriteLine("Usuário cadastrado com sucesso!");
        Console.ReadKey();
    }
}