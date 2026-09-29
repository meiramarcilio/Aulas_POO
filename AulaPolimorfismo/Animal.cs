public class Animal
{
	public string Nome {get; set;}
	public virtual void FazerSom()
	{
		Console.WriteLine("O animal faz um som");
	}
	public virtual void Mover()
	{
		Console.WriteLine("O animal se move");
	}
}