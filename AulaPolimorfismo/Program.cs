void FazerAnimalAgir(Animal animal)
{
    animal.FazerSom();
    animal.Mover();
} 

void Main()
{
    Animal[] animais =
    {
        new Cachorro { Nome = "Rex"},
        new Passaro { Nome = "Golinha"},
        new Cachorro { Nome = "Brabao"}
    };
    foreach (var animal in animais)
    {
        FazerAnimalAgir(animal);
        Console.WriteLine("---");
    }

    // Cachorro cachorro = new Cachorro(){ Nome = "Brabao" };
    // FazerAnimalAgir(cachorro);
    // FazerAnimalAgir(new Passaro { Nome = "Piu-piu" });
 
    // Ctrl + K, Ctrl + C = Comentar
    // Cachorro cachorro = new Cachorro();
    // cachorro.Nome = "Rex";
    // Passaro passaro = new Passaro();
    // passaro.Nome = "Golinha";
    // cachorro.FazerSom();
    // passaro.FazerSom();
}



Main();