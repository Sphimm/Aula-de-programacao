using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Humano : Personagem
    {

        public Humano()
        {
            
            Vida = 100;

            Console.Write("Escreva o nome do Humano: ");
            Nome = Console.ReadLine();

            Dano = 10.5f;

            lingua = "Português";

        }

        public override float VidaAtual()
        {
            
            Console.WriteLine($"Vida de {Nome}, o Humano: {Vida}");
            return Vida;

        }

        public override float Atacar()
        {
            
            Console.WriteLine($"Ataque de {Nome}, o Humano: {Dano}");
            return Dano;

        }

        public override void Morrer(Personagem atacante)
        {
            Console.WriteLine($"{atacante.Nome} me matou! E eu vou me vingar! Disse {Nome} em {lingua}");
        }

    }
}
