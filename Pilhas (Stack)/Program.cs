using System.Collections.Generic;
using Pilhas__Stack_;

Console.WriteLine("Selecione um dos itens abaixo:");

Console.WriteLine();

Console.WriteLine("1 - Criar Pilha");
Console.WriteLine("2 - Adicionar item à pilha");
Console.WriteLine("2 - Adicionar item à pilha");

int opcao = int.Parse(Console.ReadLine());
Stack Pilha = new Stack();

if (opcao == 0)
{
    Pilha.Criar_Stack();
}