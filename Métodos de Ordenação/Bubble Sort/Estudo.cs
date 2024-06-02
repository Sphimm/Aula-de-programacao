using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    public class Estudo
    {

        int[] vetor;        
        
        public void Est()
        {

            vetor = new int[] { 5, 3, 2, 4, 7, 1, 0, 6, 9, 8 };

            Exibir();

            Console.WriteLine();

            for (int i = 0; i < vetor.Length - 1; i++)
            {

                for (int n = i + 1; n < vetor.Length; n++)
                {
                    
                    if (vetor[i] > vetor[n])
                    {

                        int temp = vetor[i];
                        vetor[i] = vetor[n];
                        vetor[n] = temp;

                    }

                }

            }

            Exibir();

        }

        public void Exibir()
        {

            foreach (int num in vetor)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

        }
    }
}
