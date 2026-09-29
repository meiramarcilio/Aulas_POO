public class Cachorro: Animal
{
	public override void FazerSom()
	{
		Console.WriteLine($"{Nome} faz: au-au");
	}
	public override void Mover()
	{
		Console.WriteLine($"{Nome} corre com quatro patas");
	}
}