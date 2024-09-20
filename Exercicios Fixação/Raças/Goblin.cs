using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixação.Personagem
{
    public class Goblin : Personagem
    {

        public Goblin(string nome, Classe tipo) : base(nome, tipo)
        {
            forca = 3;
            velocidade = 20;
            agilidade = 7;
        }

    }

}
