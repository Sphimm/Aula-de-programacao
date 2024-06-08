using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa;

namespace Programa
{
    public class Jogadas
    {

        public int jogadorPoint;
        public int adversarioPoint;
        public int escolha;
        public int escolhaAd;
        public List<int> randomNum = new List<int>();
        public List<int> jogadorNum = new List<int>();
        public string[] Opcoes = new string[] { "Pedra", "Papel", "Tesoura"};

        Random random = new Random();

        public void Add(int add)
        {
            escolha = add;
            jogadorNum.Add(add);
            Console.WriteLine();
            Console.WriteLine($"Você escolheu: '{Opcoes[add]}'");
            Console.WriteLine();
        }

        public void Random()
        {
            escolhaAd = random.Next(0, 3);
            randomNum.Add(escolhaAd);         
            Console.WriteLine("Seu adversário escolheu: " + escolhaAd + " - " + Opcoes[escolhaAd]);
            Console.WriteLine();
        }

        public void Comparação()
        {
            
            switch (escolha)
            {
                /* Pedra */ case 0:
                    
                    if (escolhaAd == 2) // Tesoura
                    {
                        Console.WriteLine("Ponto para o Jogador");
                        jogadorPoint++;

                        break;
                    }

                    else if (escolhaAd == 1) // Papel
                    {
                        
                        Console.WriteLine("Ponto para o Adversário");
                        adversarioPoint++;

                        break;
                    }

                    else // Pedra
                    {
                        Console.WriteLine("Empate");
                        break;
                    }                       

                /* Papel */ case 1:

                if (escolhaAd == 0) // Pedra
                {
                    Console.WriteLine("Ponto para o Jogador");
                    jogadorPoint++;

                    break;
                }
    
                else if (escolhaAd == 2) // Tesoura
                {
                    Console.WriteLine("Ponto para o Adversário");
                    adversarioPoint++;

                    break;
                }
    
                else // Papel
                {
                    Console.WriteLine("Empate");
                     break;
                }

                /* Tesoura */ case 2:

                    if (escolhaAd == 1) // Papel
                    {
                        Console.WriteLine("Ponto para o Jogador");
                        jogadorPoint++;

                        break;
                    }
        
                    else if (escolhaAd == 0) // Pedra
                    {
                        Console.WriteLine("Ponto para o Adversário");
                        adversarioPoint++;

                        break;
                    }
        
                    else // Tesoura
                    {
                        Console.WriteLine("Empate");
                        break;
                    }

                default:
                    break;
            }

        }
    }
}
