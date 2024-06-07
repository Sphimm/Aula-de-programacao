using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa;

namespace Programa
{
    public class Jogadas
    {

        public int jogadorPoint;
        public int adversarioPoint;
        public Queue<int> randomNum = new Queue<int>();
        public Queue<int> jogadorNum = new Queue<int>();
        public string[] Opcoes = new string[] { "Pedra", "Papel", "Tesoura", "Voltar" };

        public void Add(int add)
        {
            jogadorNum.Enqueue(add);
            Console.WriteLine();
            Console.WriteLine($"Você escolheu: '{Opcoes[add]}'");
            Console.WriteLine();
        }

        public void Remover()
        {
            Console.WriteLine();
            Console.WriteLine($"O item: '{jogadorNum.Peek()}' foi removido");
            jogadorNum.Dequeue();
            Console.WriteLine();
        }

        public void Spy()
        {
            Console.WriteLine();
            Console.WriteLine($"O primeiro item da fila é: '{jogadorNum.Peek()}'");
            Console.WriteLine();
        }

        public void Tentativas()
        {
            Console.WriteLine();
            Console.WriteLine("Os itens da fila são:");
            Console.WriteLine();
            foreach (int item in jogadorNum)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        public void Random()
        {
            Random random = new Random();
            randomNum.Enqueue(random.Next(0, 2));
            Console.WriteLine("Seu adversário escolheu: " + Opcoes[randomNum.Peek()]);
        }

        public int Comparação()
        {
            if(jogadorNum.Peek() == 0)
            {
                if(randomNum.Peek() == 1) // Papel
                {
                    Console.WriteLine("Você perdeu");

                    adversarioPoint++;
                    return 0;
                }
                else if(randomNum.Peek() == 2) // Tesoura
                {
                    Console.WriteLine("Você ganhou");

                    jogadorPoint++;
                    return 1;
                }
                else
                {
                    Console.WriteLine("Empate");

                    return 2;
                }
            } // Pedra

            else if(jogadorNum.Peek() == 1)
            {
                if (randomNum.Peek() == 2)
                {
                    Console.WriteLine("Você perdeu");

                    adversarioPoint++;
                    return 0;
                }
                else if (randomNum.Peek() == 0)
                {
                    Console.WriteLine("Você ganhou");

                    jogadorPoint++;
                    return 1;
                }
                else
                {
                    Console.WriteLine("Empate");

                    return 2;
                }
            } // Papel

            else if(jogadorNum.Peek() == 2)
            {
                if (randomNum.Peek() == 0)
                {
                    Console.WriteLine("Você perdeu");

                    adversarioPoint++;
                    return 0;
                }
                else if (randomNum.Peek() == 1)
                {
                    Console.WriteLine("Você ganhou");

                    jogadorPoint++;
                    return 1;
                }
                else
                {
                    Console.WriteLine("Empate");

                    return 2;
                }
            } // Tesoura

            else
            {
                return 3;
            }

        }
    }
}
