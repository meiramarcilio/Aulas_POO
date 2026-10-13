public class Emprestimo
{
    public int IdEmprestimo { get; set; }
    public int IdUsuario { get; set; }
    public int IdLivro { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }
    public Usuario Usuario { get; set; } = null!;
    public Livro Livro { get; set; } = null!;

    public Emprestimo()
    {

    }

    public Emprestimo(Usuario usuario, Livro livro)
    {
        Usuario = usuario;
        this.IdUsuario = usuario.IdUsuario;

        Livro = livro;
        this.IdLivro = livro.IdLivro;
    }

    internal void Cadastrar(List<Usuario> usuarios, List<Livro> livros)
    {
        Console.WriteLine("Realizando empréstimo...");
        Console.Write("Digite o E-mail do usuário: ");
        string emailUsuario = Console.ReadLine() ?? string.Empty;
        // Checar se o usuário existe na lista:
        var objUsuario = usuarios.Find(u => u.Email == emailUsuario);
        if (objUsuario == null)
        {
            Console.WriteLine("Usuário não encontrado.");
            Console.ReadKey();
            return;
        }
        // Tenta localizar o livro:
        Console.Write("Digite o Titulo do livro: ");
        string tituloLivro = Console.ReadLine() ?? string.Empty;
        var objLivro = livros.Find(l => l.Titulo == tituloLivro);
        if (objLivro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            Console.ReadKey();
            return;
        }
        this.IdUsuario = objUsuario.IdUsuario;
        this.IdLivro = objLivro.IdLivro;
        this.DataEmprestimo = DateTime.Now;
        Console.WriteLine("Empréstimo realizado com sucesso!");
        Console.ReadKey();
    }
}