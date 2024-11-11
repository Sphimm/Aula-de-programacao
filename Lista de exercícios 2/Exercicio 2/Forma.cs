using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public abstract class Forma
    {
        public int num_lados { get; set; }
        public string nome { get; set; }

        public virtual void CriarForma()
        {
            Console.WriteLine($"Criando forma de {num_lados} lados");
        }

        public virtual void calcularArea()
        {
            Console.WriteLine($"Calculando a área do {nome}");
        }

    }
}
