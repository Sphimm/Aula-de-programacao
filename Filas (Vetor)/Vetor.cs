using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Filas__Vetor_;

namespace Filas__Vetor_
{

    public class Vetor
    {
        string?[]? fila;
        int indice = 0;
        string? item;

        public void Criar()
        {
            int Out;
            string? tamanho;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Qual o tamanho da fila?");
                Console.WriteLine();
                tamanho = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(tamanho, out Out))
                {
                    Console.WriteLine("O valor digitado é inválido");
                    Console.WriteLine("Digite novamente:");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    fila = new string[Out];                    
                    Console.WriteLine("Fila criada com sucesso!");
                    Console.WriteLine();
                }
            } while (!int.TryParse(tamanho, out _));
        }

        public void Adicionar()
        {
            Console.WriteLine();
            Console.Write("Digite o item que deseja adicionar: ");
            item = Console.ReadLine();

            fila[indice] = item;
            indice++;
            Console.WriteLine();
            Console.WriteLine($"O item: '{item}' foi adicionado");
            Console.WriteLine();
        }

        public void Remover()
        {
            Console.WriteLine();
            Console.WriteLine($"O item: '{fila[0]}' foi removido");
            fila[0] = null;
            Console.WriteLine();

            for (int i = 0; i < indice; i++)
            {
                fila[i] = fila[i + 1];
                fila[i + 1] = null;
            }
        }

        public void Spy()
        {
            Console.WriteLine();
            Console.WriteLine($"O primeiro item da fila é: '{fila[0]}'");
            Console.WriteLine();
        }

        public void View()
        {
            Console.WriteLine();
            Console.WriteLine("Os itens da fila são:");
            Console.WriteLine();

            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(fila[i]);
                Console.WriteLine();
            }
        }
    }
}
