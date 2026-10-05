void Main()
{
    int opcao = 0;
    List<Usuario> usuarios = new List<Usuario>();
    List<Livro> livros = new List<Livro>();
    List<Emprestimo> emprestimos = new List<Emprestimo>();
    do
    {
        Console.Clear(); // limpa a tela
        Console.WriteLine("---MENU---");
        Console.WriteLine("1. Cadastrar Usuário");
        Console.WriteLine("2. Cadastrar Livro");
        Console.WriteLine("3. Realizar Empréstimo");
        Console.WriteLine("4. Devolver Livro");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Usuario usuario = new Usuario();
                    usuario.Cadastrar();
                    usuarios.Add(usuario);
                    break;
                case 2:
                    Livro livro = new Livro();
                    livro.Cadastrar();
                    livros.Add(livro);
                    break;
                case 3:
                    Emprestimo emprestimo = new Emprestimo();
                    emprestimo.Cadastrar();
                    emprestimos.Add(emprestimo);
                    break;
                case 4:
                    // Lógica para devolver livro
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
        }
    } while (opcao != 5);
}

Main();