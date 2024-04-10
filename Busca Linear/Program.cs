string?[] nomes = new string[5];
string? nomeBusca;
int count = 0;

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Escreva o nome da posição: {i + 1}");
    Console.WriteLine();
    nomes[i] = Console.ReadLine();
    Console.WriteLine();
}

Console.WriteLine("Escreva o nome para ser buscado:");
Console.WriteLine();
nomeBusca = Console.ReadLine();
Console.WriteLine();

foreach (string nome in nomes)
{
    count++;

    if (nome.Equals(nomeBusca))
    {
        Console.WriteLine($"Nome: {nome}, encontrado na posição {count}");
        Console.WriteLine();
        break;
    }

    else
    {
        Console.WriteLine($"Nome não encontrado, nome atual: {nome}, na posição {count}");
        Console.WriteLine();
    }
}