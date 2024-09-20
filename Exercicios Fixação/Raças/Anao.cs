using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixação.Personagem
{
    public class Anao : Personagem
    {

        public Anao(string nome, Classe tipo) : base(nome, tipo)
        {
            forca = 15;
            velocidade = 6;
            agilidade = 7;
        }

    }

}
