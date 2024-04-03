using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas__Vetor_
{
    public class Vetor
    {
        string[] fila = new string[5];
        int indice = 0;
        public void Adicionar(string? add)
        {
            fila[indice] = add;
            indice++;
            Console.WriteLine();
            Console.WriteLine($"O item: '{add}' foi adicionado");
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
    }
}
