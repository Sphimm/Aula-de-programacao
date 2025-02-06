using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão_Vetores
{
    public class Calculos
    {

        int[] vetor = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        int[] vetor2 = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        public void Soma()
        {

            Console.WriteLine("Soma");

            int soma = 0;

            foreach (int i in vetor)
            {
                soma += i;
            }

            Console.WriteLine(soma);
            Console.WriteLine();

        }

        public void reverse()
        {

            Console.WriteLine("Reverse");

            for (int i = vetor2.Length - 1; i >= 0; i--)
            {
                
                Console.Write(vetor2[i] + " ");

            }

            Console.WriteLine();

        }

        public void pares()
        {

            Console.WriteLine("Pares");

            int pares = 0;

            foreach (int i in vetor2)
            {
                if (i % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine(pares);
            Console.WriteLine();

        }

    }
}
