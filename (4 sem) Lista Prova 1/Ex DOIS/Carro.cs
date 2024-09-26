using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_DOIS
{
    public class Carro : Veiculo
    {

        public override void Acelerar()
        {
            Console.WriteLine($"Acelerando o carro modelo: {Modelo}");
            Console.WriteLine();
        }

        public override void Frear()
        {
            Console.WriteLine($"Freando o carro modelo: {Modelo}");
            Console.WriteLine();
        }

    }

}
