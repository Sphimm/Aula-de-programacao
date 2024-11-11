using Exercicio_1;

List<IVeiculo> veiculos = new List<IVeiculo>();

for (int i = 0; i < 10; i++)
{ 

    int random = new Random().Next(1, 4);

    if (random == 1) { veiculos.Add(new Carro()); }
    else if (random == 2) { veiculos.Add(new Aviao()); }
    else if (random == 3) { veiculos.Add(new Bicicleta()); }

}

foreach (IVeiculo veiculo in veiculos)
{
    Console.WriteLine("Veiculo: " + veiculo.idPersonal);
    veiculo.Mover();
    Console.WriteLine();
}