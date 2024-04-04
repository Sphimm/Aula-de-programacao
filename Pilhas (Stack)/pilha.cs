using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas__Stack_
{
    public class Stack
    {
        Stack<string> pilha {  get; set; }

        public void Criar_Stack()
        {
        pilha = new Stack<string>();
        Console.WriteLine("A Pilha foi criada");
        Console.WriteLine();
        }

        public void Add_Stack(string item)
        {
            Console.WriteLine();
            Console.WriteLine($"O item: '{item}' foi adicionado");
            pilha.Push(item);
            Console.WriteLine();
        }

        public void Clear_Stack()
        {
            Console.WriteLine();
            Console.WriteLine($"O item: '{pilha.Peek()}' foi removido");
            Console.WriteLine();
        }

        public void Spy_Stack()
        {
            Console.WriteLine();
            Console.WriteLine($"O primeiro item da fila é: '{pilha.Peek()}'");
            Console.WriteLine();
        }

        public void View_Stack()
        {
            foreach (string? item in pilha)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }











    }
}
