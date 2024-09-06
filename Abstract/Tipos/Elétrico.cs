using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Tipos
{
    public class Elétrico : Carro
    {

        public override void Acelerar()
        {
            Console.WriteLine("Acelera! Energia!");
        }

        public override void Frear()
        {
            Console.WriteLine("Freia! Energia!");
        }

        public override void Virar()
        {
            Console.WriteLine("Vira! Energia!");
        }

    }
}
