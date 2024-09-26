using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_DOIS
{
    public abstract class Veiculo
    {

        public string Marca { get; private set; }
        public string Modelo { get; private set; }

        public Veiculo()
        {
            
            Console.Write("Insira a marca do veiculo: ");
            Marca = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Insira o modelo do veiculo: ");
            Modelo = Console.ReadLine();
            Console.WriteLine();

        }

        public abstract void Acelerar();

        public abstract void Frear();

    }
}
