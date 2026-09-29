public class Animal
{
    public string Nome {get; set;}
    public string Especie {get; set;}
    public int Idade {get; set;}
    public bool EstaDormindo {get; set;}

    public Animal()
    {        
    }

    public Animal(string nome, string especie, int idade, bool estaDormindo)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
        EstaDormindo = estaDormindo;
    }

    public void Dormir()
    {
        EstaDormindo = true;
    }

    public void Acordar()
    {
        EstaDormindo = false;
    }

    public void FazerSom()
    {
         Console.WriteLine("O animal fez um som.");
    }

    public void ApresentarSe()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, sou um(a) {Especie} e tenho {Idade} anos.");
    }
}