using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercícios_Fixação;

namespace Exercícios_Fixação
{
    public enum Classe
    {
        Guerreiro,
        Mago,
        Caçador,
        Druida,
        Paladino,
        Ladrao
    }

    public abstract class Personagem
    {

        public string nome { get; set; }

        protected int forca { get; set; }

        protected int velocidade { get; set; }

        protected int agilidade { get; set; }

 
        public Personagem(string nome, Classe tipo)
        {

            this.nome = nome;

            Classe classe = tipo;

            forca = 10;
            
            velocidade = 10;
            
            agilidade = 10;

        }

        public int Mover()
        {
            Console.WriteLine($"{nome} se moveu {agilidade} quadrados");
            return agilidade;
        }

        public int pular()
        {
            Console.WriteLine($"{nome} pulou {forca} quadrados");
            return forca;
        }

        public int Dash()
        {
            Console.WriteLine($"{nome} deu um Dash de {velocidade} quadrados");
            return velocidade;
        }

    }
}
