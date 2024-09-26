using Ex_QUATRO;

List<IAnimal> animais = new List<IAnimal>();

Console.WriteLine("Bem-vindo ao PetShop!");
Console.WriteLine();

animais.Add(new Cachorro());
animais.Add(new Gato());

foreach (IAnimal animal in animais)
{
    Console.WriteLine($"Nome: {animal.Name}");
    Console.WriteLine();
    animal.Comer();
    animal.Dormir();
    animal.vocalizar();
}