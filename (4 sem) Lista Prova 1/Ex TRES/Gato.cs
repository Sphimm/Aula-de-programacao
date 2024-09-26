using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_QUATRO
{
    public class Gato : IAnimal
    {

        public string Name { get; set; }

        public Gato()
        {

            Console.Write("Escolha o nome do gatinho: ");
            Name = Console.ReadLine();
            Console.WriteLine();

        }

        public void Comer()
        {
            Console.WriteLine("Gato comendo...");
            Console.WriteLine();
        }

        public void Dormir()
        {
            Console.WriteLine("Gato dormindo...");
            Console.WriteLine();
        }

        public void vocalizar()
        {
            Console.WriteLine("Miau!");
            Console.WriteLine();
        }

    }
}
