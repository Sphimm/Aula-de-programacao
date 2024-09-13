using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Fixação
{
    public class Orc : Personagem
    {

        public Orc(string nome, Classe tipo) : base(nome, tipo)
        {
            forca = 20;
            velocidade = 5;
            agilidade = 5;
        }

    }
}
