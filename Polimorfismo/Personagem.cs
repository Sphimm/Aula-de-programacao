using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Personagem
    {

        public float Vida { get; protected set; }

        public string Nome { get; set; }

        public float Dano { get; protected set; }

        public string lingua { get; set; }




        public virtual float VidaAtual()
        {

            if (Vida <= 0)
            {

                Vida = 0;

            }

            Console.WriteLine($"Vida: {Vida}");

            return Vida;

        }

        public virtual float Atacar()
        {
            Console.WriteLine($"Ataque: {Dano}");
            return Dano;
        }

        public void ReceberDano(Personagem atacante)
        {                                   

            atacante.Atacar();

            Console.WriteLine($"{atacante.Nome} te atacou! Dano recebido: {atacante.Dano}");
            Vida -= atacante.Dano;

            VidaAtual();

            if (Vida <= 0)
            {

                Morrer(atacante);

            }

        }

        public virtual void Morrer(Personagem atacante)
        {
            Console.WriteLine($"{Nome} morreu!");
        }

    }
}
