using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Fixação
{
    public class Humano : Personagem
    {

        public Humano(string nome, Classe tipo) : base(nome, tipo)
        {
            forca = 5;
            velocidade = 15;
            agilidade = 10;
        }

    }
}
