using System.Collections.Generic;
using Pilhas__Stack_;

Stack fila = new Stack();
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
        fila.Criar_Stack();
    } //Criar Pilha

    else if (opcao == 2)
    {
        Console.WriteLine("Escreva o item a ser adicionado:");
        Console.WriteLine();
        item = Console.ReadLine();
        fila.Add_Stack(item);
    } //Adicionar Item

    else if (opcao == 3)
    {
        fila.Clear_Stack();
    } //Excluir Item

    else if (opcao == 4)
    {
        fila.Spy_Stack();
    } //Ver Item no Topo

    else if (opcao == 5)
    {
        fila.View_Stack();
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