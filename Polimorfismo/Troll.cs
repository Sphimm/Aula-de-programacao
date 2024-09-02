using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Troll : Personagem
    {

        public Troll()
        {

            Vida = 200;

            Console.Write("Escreva o nome do Orc: ");
            Nome = Console.ReadLine();

            Dano = 20.5f;

            lingua = "Inglês";

        }

        public override float VidaAtual()
        {

            if (Vida <= 0)
            {

                Vida = 0;

            }

            Console.WriteLine($"Vida de {Nome}, o Troll: {Vida}");

            return Vida;

        }

        public override float Atacar()
        {

            Console.WriteLine($"Ataque de {Nome}, o Troll: {Dano}");
            return Dano;

        }

        public override void Morrer(Personagem atacante)
        {
            Console.WriteLine($"{atacante.Nome} me matou! E eu vou me vingar! Disse {Nome} em {lingua}");
        }

    }
}
