using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{

    public class FatorialC
    {

        public int Calcular_NaoRecursivo(int numero)
        {
            int n = 1;
            do
            {

                if (numero == 0 || numero == 1)
                {

                    n *= 1;
                    numero--;

                }

                else
                {

                    n *= numero;
                    numero--;

                }

            } while (numero > 0);

            return n;
        }

        public int Calcular_Recursivo(int numero)
        {

            if (numero == 0 || numero == 1)
            {

                return numero * 1;

            }           

                return numero * Calcular_Recursivo(numero - 1);
        }

        public int Formula_fudida(int n, int k)
        {

            return Calcular_Recursivo(n) / (Calcular_NaoRecursivo(k) * Calcular_Recursivo(n - k));

        }
    }
}
