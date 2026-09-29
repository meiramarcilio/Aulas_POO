
Animal anim1 = new Animal(){ 
    Nome = "Rex", 
    Especie = "Cachorro", 
    Idade = 5, 
    EstaDormindo = false 
};

Animal anim2 = new Animal("Mimi", "Gato", 3, true);

anim1.ApresentarSe();
anim2.ApresentarSe();