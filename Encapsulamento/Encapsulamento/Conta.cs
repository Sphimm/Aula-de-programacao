using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Conta
    {
        private string? cpf;
        private string? nome;
        private double saldo;

        public Conta(string cpf, string nome, double saldo)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.saldo = saldo;
        }

        public string Cpf { get { return cpf; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public double Saldo { get { return saldo; } set { saldo = value; } }
    }
}
