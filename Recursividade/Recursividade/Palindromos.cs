using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class Palindromos
    {

        public bool Calcular(string palavra)
        {

            palavra = palavra.ToLower();

            if (palavra != null)
            {
                int fator;
                char inicial = palavra[0];
                char final = palavra[palavra.Length - 1];

                if (inicial.Equals(final))
                {
                    Console.WriteLine($"{inicial} = {final}");

                    if (palavra.Length > 2 )
                    {
                        palavra = palavra.Substring(1, palavra.Length - 2);
                    }

                    else
                    {
                        return true;
                    }
                    
                    return Calcular(palavra);
                }

                else
                {
                    return false;
                }
            }

            else { return true; }
            
        }
    }
}