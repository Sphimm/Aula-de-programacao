using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_UM
{
    public abstract class Operacoes
    {

        public abstract void Depositar(double valor);

        public abstract void Sacar(double valor);

        public void Transacao(string tipo, double s)
        {
            Console.WriteLine($"{tipo} realizado com sucesso!");
            Console.WriteLine($"Saldo atual: {s}");
            Console.WriteLine();
        }

    }
}
