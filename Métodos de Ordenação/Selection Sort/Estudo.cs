using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    public  class Estudo
    {
        int[] vetor;

        public void Est()
        {

            vetor = new int[] { 5, 3, 2, 4, 7, 1, 0, 6, 9, 8 };

            Exibir();

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                int esquerda = i;

                for (int n = i + 1; n < vetor.Length; n++)
                {
                    if (vetor[esquerda] > vetor[n])
                    {
                        esquerda = n;
                    }
                }

                if (i != esquerda)
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[esquerda];
                    vetor[esquerda] = troca;
                }
            }

            Exibir();

        }

        public void Exibir()
        {

            foreach (int num in vetor)
            {
                Console.Write(vetor[num] + " ");
            }

            Console.WriteLine();

        }
    }
}
