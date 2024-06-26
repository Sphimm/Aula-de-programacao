﻿Console.WriteLine("Qual o tamanho da lista?");
int tamanho = int.Parse(Console.ReadLine());
Console.WriteLine();

int[] lista = new int[tamanho];

int inicio = 0; 
int meio; 
int fim = lista.Length - 1;
int procurado;

for (int i = 0; i < lista.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    lista[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < lista.Length - 1; i++)
{
    for (int j = i + 1; j < lista.Length; j++)
    {
        if (lista[i] > lista[j])
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
    }
}

Console.WriteLine("Digite o número que deseja procurar: ");
Console.WriteLine();
procurado = int.Parse(Console.ReadLine());
Console.WriteLine();

do
{
    meio = (inicio + fim) / 2;
    if (lista[meio] == procurado)
    {
        Console.WriteLine($"O número {procurado} foi encontrado na posição: {meio + 1} no índice {meio}");
        Console.WriteLine();
        break;
    }
    
    else if (lista[meio] < procurado)
    {
        inicio = meio + 1;
    }
    
    else
    {
        fim = meio - 1;
    }
} while (inicio <= fim);
