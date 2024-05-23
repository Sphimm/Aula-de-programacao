﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Jogadas
    {
        public Queue<int> Escolha = new Queue<int>();

        public void Add(int add)
        {
            Escolha.Enqueue(add);
            Console.WriteLine();
            Console.WriteLine($"Sua jogada foi: '{add}'");
            Console.WriteLine();
        }

        public void Remover()
        {
            Console.WriteLine();
            Console.WriteLine($"O item: '{Escolha.Peek()}' foi removido");
            Escolha.Dequeue();
            Console.WriteLine();
        }

        public void Spy()
        {
            Console.WriteLine();
            Console.WriteLine($"O primeiro item da fila é: '{Escolha.Peek()}'");
            Console.WriteLine();
        }

        public void View()
        {
            Console.WriteLine();
            Console.WriteLine("Os itens da fila são:");
            Console.WriteLine();
            foreach (int item in Escolha)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}