using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main;

namespace Main
{
    public class Jogo : Inicializacoes
    {
        Jogadas jogadas;
        Interface_Inicial UI;

        public Jogo(Interface_Inicial UI)
        {
            this.UI = UI;
            this.jogadas = new Jogadas(this, UI);
        }

        public string? Nome;   
        public int jogadorPoint;
        public int adversarioPoint;

        public void IniciarJogo()
        {
            UI.Linha();
            Console.WriteLine();

            Console.WriteLine("Iniciando Jogo");
            NomeJogador();
            Jogar();

        }

        public void NomeJogador()
        {            
            Console.WriteLine();

            Console.Write("Digite o seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("O nome do jogador é: " + Nome);

            Console.WriteLine();
        }

        public void Jogar()
        {
            jogadas.Add(Escolha());
            jogadas.Random();

        }

        public int Escolha()
        {
            int opcao;
            UI.Mlinha();
            Console.WriteLine();

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();

            for (int i = 0; i < jogadas.Opcoes.Length; i++)
            {
                
                if (i == 3)
                {
                    Console.WriteLine();
                }

                Console.WriteLine($"{i} - {jogadas.Opcoes[i]}");
            }

            opcao = ReadOut();

            return opcao;
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
            Console.Write("Digite aqui: ");

            string? entrada = Console.ReadLine();
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

            while (!(opcao >= 0 && opcao < 4))
            {
                Console.WriteLine("Opção inválida (A entrada não está entre 0 e 3). Tente novamente.");
                ValidarEntrada(Read());

            }

            return opcao;

        }

    }
}
