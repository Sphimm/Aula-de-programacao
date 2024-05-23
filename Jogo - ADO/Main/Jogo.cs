﻿using System;
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
        Interface_Inicial UI = new Interface_Inicial();
        public string? Nome;
        public string[] Opcoes = new string[] { "Pedra", "Papel", "Tesoura", "Voltar" };
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
            UI.Linha();
            Console.WriteLine();

            Console.WriteLine("Iniciando Jogo");
            NomeJogador();
            Jogar();

        }

        public void NomeJogador()
        {            
            Console.WriteLine();

            Console.WriteLine("Digite o seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("O nome do jogador é: " + Nome);

            Console.WriteLine();
        }

        public void Jogar()
        {
            jogadas.Add(Escolha());

        }

        public int Escolha()
        {
            int opcao;
            UI.Mlinha();
            Console.WriteLine();

            Console.Write("Escolha uma opção:");

            for (int i = 0; i < Opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {Opcoes[i]}");
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

            while (!(opcao >= 0 && opcao < 4))
            {
                Console.WriteLine("Opção inválida (A entrada não está entre 0 e 3). Tente novamente.");
                ValidarEntrada(Read());

            }

            return opcao;

        }
    }
}