using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_UM
{ 
    public class ContaBancaria : Operacoes
    {

        private int numeroConta;
        private double saldo;


        public ContaBancaria(int numeroConta, double saldo)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldo;
        }

        public override void Depositar(double valor)
        {

            saldo += valor;


        }

        public override void Sacar(double valor)
        {
        
            if (saldo >= valor)
            {
            
                saldo -= valor;

            }

            else
            {
            
                Console.WriteLine("Saldo insuficiente!");

            }

        }

    }

}
