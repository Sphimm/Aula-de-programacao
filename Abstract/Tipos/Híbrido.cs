using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Tipos
{
    public class Híbrido : Carro
    {

        public override void Acelerar()
        {
            Console.WriteLine("Acelera! CO² + Energia!");
        }

        public override void Frear()
        {
            Console.WriteLine("Freia! CO² + Energia!");
        }

        public override void Virar()
        {
            Console.WriteLine("Vira! CO² + Energia!");
        }

    }
}
