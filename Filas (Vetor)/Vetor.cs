using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas__Vetor_
{
    public class Vetor
    {
        string[]? fila;
        int indice = 0;

        public void Criar(int add)
        {
            Console.WriteLine();
            fila = new string[add];
            Console.WriteLine($"Fila criada com {add} espaços");
            Console.WriteLine();
        }

        public void Adicionar(string? add)
        {
            if (indice < fila.Length)
            {
                fila[indice] = add;
                indice++;
                Console.WriteLine();
                Console.WriteLine($"O item: '{add}' foi adicionado");
                Console.WriteLine();
            }
            
            else
            {
                Console.WriteLine("A fila está cheia");
                Console.WriteLine();
                return;
            }
        }

        public void Remover()
        {
            if (indice > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"O item: '{fila[0]}' foi removido");
                fila[0] = null;
                indice--;
                Console.WriteLine();

                for (int i = 0; i < indice; i++)
                {
                    if (indice > 0)
                    {
                        fila[i] = fila[i + 1];
                        fila[i + 1] = null;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            
            else
            {
                Console.WriteLine("A fila está vazia");
                Console.WriteLine();
                return;
            }
        }

        public void Spy()
        {
            if (indice > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"O primeiro item da fila é: '{fila[0]}'");
                Console.WriteLine();
            }            
            else
            {               
                Console.WriteLine("A fila está vazia");
                Console.WriteLine();
                return;
            }
        }

        public void View()
        {
            if (indice > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Os itens da fila são:");
                Console.WriteLine();

                foreach (string? item in fila)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine();
                    }
                }
            }
            
            else
            {
                Console.WriteLine("A fila está vazia");
                Console.WriteLine();
                return;
            }
        }
    }
}
