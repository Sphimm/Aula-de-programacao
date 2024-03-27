using System.Collections.Generic;
using Pilhas__Stack_;

Stack Pilha = new Stack();
Interface UI = new Interface();
string? item;
bool verf = true;
int opcao;

while (verf)
{
    UI.Inicio();
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    if (opcao == 1)
    {
        Pilha.Criar_Stack();
    }

    else if (opcao == 2)
    {
        Console.WriteLine("Escreva o item a ser adicionado:");
        Console.WriteLine();
        item = Console.ReadLine();
        Pilha.Add_Stack(item);
    }

    else if (opcao == 3)
    {
        Pilha.Pop_Stack();
    }

    else if (opcao == 4)
    {
        Pilha.Spy_Stack();
    }

    else if (opcao == 5)
    {
        Pilha.View_Stack();
    }

    else {verf = false;}

    Console.WriteLine();
}