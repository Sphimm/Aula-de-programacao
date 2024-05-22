using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Interface_Inicial
    {
        public int Menu()
        {
            int opcao;

            Linha();

            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao Pedra Papel e Tesoura!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();

            Console.WriteLine("1 - Iniciar Jogo");
            Console.WriteLine("2 - Exibir Resumo");
            Console.WriteLine("3 - Sair");

            opcao = ReadOut();

            Linha();

            return opcao;

        }

        private void Linha()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
        }

        private int ReadOut()
        {
            string? entrada = Read();
            int opcao = ValidarEntrada(entrada);
            return opcao;
        }

        private string? Read()
        {
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");
            string? entrada = Console.ReadLine();
            Console.WriteLine();
            return entrada;
        }

        private int ValidarEntrada(string? entrada)
        {
            int opcao;

            while (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Opção inválida (A entrada não foi numérica). Tente novamente.");
                entrada = Read();
            }

            while (!(opcao > 0 && opcao < 4))
            {
                Console.WriteLine("Opção inválida (A entrada não está entre 1 e 3). Tente novamente.");
                ValidarEntrada(Read());

            }

            return opcao;

        }

    }
}
