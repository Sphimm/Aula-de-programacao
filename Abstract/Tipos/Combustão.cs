using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Tipos
{
    public class Combustão : Carro
    {

        public override void Acelerar()
        {
            Console.WriteLine("Acelera! CO², CO², CO²");
        }

        public override void Frear()
        {
            Console.WriteLine("Freia! CO², CO², CO²");
        }

        public override void Virar()
        {
            Console.WriteLine("Vira! CO², CO², CO²");
        }

    }
}
