using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_DOIS
{
    public class Moto : Veiculo
    {

        public override void Acelerar()
        {
            Console.WriteLine($"Acelerando a moto modelo: {Modelo}");
            Console.WriteLine();
        }

        public override void Frear()
        {
            Console.WriteLine($"Freando a moto modelo: {Modelo}");
            Console.WriteLine();
        }

    }
}
