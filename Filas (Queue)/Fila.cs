using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas__Queue_
{
    public class Queue
    {      
        Queue<string> Fila = new Queue<string>();

        public void Adicionar(string? add) 
        { 
            Fila.Enqueue(add);
            Console.WriteLine();
            Console.WriteLine($"O item: '{add}' foi adicionado");
            Console.WriteLine();
        }

        public void Remover()
        {
            Console.WriteLine();
            Console.WriteLine($"O item: '{Fila.Peek()}' foi removido");
            Fila.Dequeue();
            Console.WriteLine();
        }

        public void Spy()
        {
            Console.WriteLine();
            Console.WriteLine($"O primeiro item da fila é: '{Fila.Peek()}'");
            Console.WriteLine();
        }

        public void View() 
        {
            Console.WriteLine();
            Console.WriteLine("Os itens da fila são:");
            Console.WriteLine();
            foreach (string item in Fila)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }            
        }
    }
}
