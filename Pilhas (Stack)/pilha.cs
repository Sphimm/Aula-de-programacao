using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas__Stack_
{
    public class Stack
    {
        Stack<string> pilha {  get; set; }

        public void Criar_Stack()
        {
            Console.WriteLine("Você criou a Pilha 1");
            pilha = new Stack<string>();
            Console.WriteLine();
        }

        public void Add_Stack(string? add)
        {            
            pilha.Push(add);
            Console.WriteLine();
            Console.WriteLine($"O item: '{add}' foi adicionado");
            Console.WriteLine();
        }

        public void Pop_Stack()
        {
            Console.WriteLine($"O item: '{pilha.Peek()}' foi excluido");
            pilha.Pop();
            Console.WriteLine();
        }

        public void Spy_Stack()
        {
            Console.WriteLine($"O item no topo da pilha é: '{pilha.Peek()}'");          
            Console.WriteLine();
        }

        public void View_Stack()
        {
            int count = pilha.Count();
            string[] lista = new string[count];

            Console.WriteLine("Os itens da pilha são (Do topo para a base):");
            Console.WriteLine();

            foreach( string item in pilha )
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            /* Também funciona, mas é menos eficiente 
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(pilha.Peek());
                lista[i] = pilha.Pop();
                Console.WriteLine();
            }
            
            for (int num = lista.Length - 1; num >= 0; num--)
            {
                pilha.Push(lista[num]);
            } */
        }
    }
}
