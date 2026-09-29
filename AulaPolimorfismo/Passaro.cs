public class Passaro: Animal
{
	public override void FazerSom()
	{
		Console.WriteLine($"{Nome} faz: piu-piu");
	}
	public override void Mover()
	{
		Console.WriteLine($"{Nome} voa com asas");
	}
}