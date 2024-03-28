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
    } //Criar Pilha

    else if (opcao == 2)
    {
        Console.WriteLine("Escreva o item a ser adicionado:");
        Console.WriteLine();
        item = Console.ReadLine();
        Pilha.Add_Stack(item);
    } //Adicionar Item

    else if (opcao == 3)
    {
        Pilha.Pop_Stack();
    } //Excluir Item

    else if (opcao == 4)
    {
        Pilha.Spy_Stack();
    } //Ver Item no Topo

    else if (opcao == 5)
    {
        Pilha.View_Stack();
    } //Ver Todos os Itens

    else 
    {
        verf = false;
        for (int i = 0; i < 100; i++)
        {
            Console.Write("=");
        }
    } //Encerrar

    Console.WriteLine();
}