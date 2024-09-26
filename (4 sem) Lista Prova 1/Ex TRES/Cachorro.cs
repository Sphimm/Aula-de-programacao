using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_QUATRO
{
    public class Cachorro : IAnimal
    {

        public string Name { get; set; }

        public Cachorro()
        {
            
            Console.Write("Escolha o nome do doguinho: ");
            Name = Console.ReadLine();
            Console.WriteLine();

        }

        public void Comer()
        {
            Console.WriteLine("Cachorro comendo...");
            Console.WriteLine();
        }

        public void Dormir()
        {
            Console.WriteLine("Cachorro dormindo...");
            Console.WriteLine();
        }

        public void vocalizar()
        {
            Console.WriteLine("Au au!");
            Console.WriteLine();
        }

    }
}
