using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas__Vetor_
{
    public class Interface
    {
        public void Inicio()
        {
            Console.WriteLine("Selecione um dos itens abaixo:");

            Console.WriteLine();

            Console.WriteLine("1 - Criar Fila");
            Console.WriteLine("2 - Adicionar item à Fila");
            Console.WriteLine("3 - Remover um item da Fila");
            Console.WriteLine("4 - Ver quem é o primeiro da Fila");
            Console.WriteLine("5 - Ver todos os itens da Fila");
            Console.WriteLine("6 - Encerrar");

            Console.WriteLine();
        }

        public void Divisao_Longa()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void Insira_Aqui()
        {
            Console.Write("Insira aqui:  ");
        }
    }
}
