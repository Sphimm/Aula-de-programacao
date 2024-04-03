using System.Collections.Generic;
using Filas__Queue_;

Queue Fila = new Queue();
Interface UI = new Interface();
bool verf = true;
string? item;
int opcao;

while (verf)
{
    UI.Divisao_Longa();
    UI.Inicio();
    UI.Divisao_Longa();

    UI.Insira_Aqui();

    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (opcao == 1)
    {
        Console.WriteLine("Escreva o item a ser adicionado:");
        Console.WriteLine();
        item = Console.ReadLine();
        Fila.Adicionar(item);
    } //Adicionar Item

    else if (opcao == 2)
    {
        Fila.Remover();
    } //Excluir Item

    else if (opcao == 3)
    {
        Fila.Spy();
    } //Ver Item no Topo

    else if (opcao == 4)
    {
        Fila.View();
    } //Ver Todos os Itens

    else
    {
        verf = false;
        for (int i = 0; i < 100; i++)
        {
            Console.Write("=");
        }
    } //Encerrar
}