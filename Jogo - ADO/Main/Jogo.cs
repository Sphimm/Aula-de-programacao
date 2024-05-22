using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main;

namespace Main
{
    internal class Jogo
    {
        Jogadas jogadas = new Jogadas();
        public string? Nome;
        public string[] Opcoes = new string[] { "Pedra", "Papel", "Tesoura" };
        public void Switch(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    IniciarJogo();
                    break;
                case 2:
                    Console.WriteLine("Exibir Resumo");
                    break;
                case 3:
                    Console.WriteLine("Sair");
                    break;
            }
        }

        private void IniciarJogo()
        {
            Console.WriteLine("Iniciando Jogo");
            NomeJogador();

        }

        public void NomeJogador()
        {
            Console.WriteLine("Digite o seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("O nome do jogador é: " + Nome);
        }

        public void Jogar()
        {
            
        }

    }
}
