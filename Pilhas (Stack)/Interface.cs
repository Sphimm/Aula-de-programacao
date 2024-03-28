using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas__Stack_
{
    public class Interface
    {
        public void Inicio()
        {
            Console.WriteLine("Selecione um dos itens abaixo:");

            Console.WriteLine();

            Console.WriteLine("1 - Criar Pilha");
            Console.WriteLine("2 - Adicionar item à Pilha");
            Console.WriteLine("3 - Remover um item da Pilha");
            Console.WriteLine("4 - Ver quem é o primeiro da Pilha");
            Console.WriteLine("5 - Ver nomes na Pilha");
            Console.WriteLine("6 – Encerrar");

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
