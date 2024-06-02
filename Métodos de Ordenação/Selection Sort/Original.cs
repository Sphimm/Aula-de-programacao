using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Original
    {
        int[] vetor;
        int menorIndice;
        int troca;

        public void Ori()
        {            

            vetor = new int[] { 5, 3, 2, 4, 7, 1, 0, 6, 9, 8 };

            /*
            int entrada;
            Console.WriteLine("Insira 10 números inteiros para serem ordenados:");
            Console.WriteLine();

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                entrada = int.Parse(Console.ReadLine());
                vetor[i] = entrada;
            }
            */

            foreach (int num in vetor)
            {
                Console.Write(vetor[num] + " ");
            }
            Console.WriteLine();

            for (int num = 0; num < vetor.Length - 1; num++) // Percorre o vetor guardando o indice do número inicial
            {
                menorIndice = num;

                for (int numOrdem = num + 1; numOrdem < vetor.Length; numOrdem++) // Percorre o vetor a partir do número inicial
                {
                    if (vetor[menorIndice] > vetor[numOrdem]) // Verifica se o numero atual é menor que o número inicial
                    {
                        menorIndice = numOrdem; // Guarda o indice do número menor
                    }
                }

                if (num != menorIndice) // Verifica se o número inicial é diferente do número menor
                {
                    troca = vetor[num]; // Guarda o número inicial
                    vetor[num] = vetor[menorIndice]; // Põe o menor no lugar do inicial
                    vetor[menorIndice] = troca; // Põe o troca no lugar do menor
                    Console.WriteLine();
                    Console.WriteLine($"Troca: {vetor[num]} <-> {vetor[menorIndice]}");
                    Console.WriteLine();
                }
            }

            foreach (int num in vetor)
            {
                Console.Write(vetor[num] + " ");
            }
            Console.WriteLine();
        }
    }
}
