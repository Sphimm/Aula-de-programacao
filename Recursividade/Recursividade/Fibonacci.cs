using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public class Fibonacci
    {

        public int Calculo(int fator)
        {

            if (fator == 1 || fator == 2)
            {

                return 1;

            }

            else
            {
                return Calculo(fator - 1) + Calculo(fator - 2);
            }

        }

        public List<int> Sequencia(int fator)
        {

            List<int> sequencia = new List<int>();

            for (int num = 1; num <= fator; num++)
            {
                sequencia.Add(Calculo(num));
            }
            return sequencia;

        }

    }
}
