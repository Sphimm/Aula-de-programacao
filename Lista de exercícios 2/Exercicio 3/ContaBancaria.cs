using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class ContaBancaria
    {

        private static int contaId = 1;
        private string titular;
        private double saldo;

        public int cId
        { get; private set; }

        public string Titular
        { get => titular; private set => titular = value; }

        public double Saldo
        { get => saldo; private set => saldo = value; }

        public ContaBancaria()
        {

            cId = contaId;
            contaId++;

            Console.Write("Informe o nome do Titular: ");
            titular = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Titular: {titular} ID: ({cId}) criado");
            Console.WriteLine();

            Console.WriteLine($"Seu saldo atual: {saldo}");
            Console.WriteLine();

        }

        public void Depositar(Log log, Funcionario fun)
        {
            double valor;

            Console.Write("Informe o valor a ser depositado: ");

            if (double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine();
                saldo += valor;
                Console.WriteLine("Deposito realizado com sucesso!");
                ConsultarSaldo();

                log.DepositoLog(fun, valor);

            }
            else
            {
                Console.WriteLine("Valor inválido");
                ConsultarSaldo();
            }

        }

        public void Sacar(Log log, Funcionario fun)
        {

            double valor;

            Console.Write("Informe o valor a ser sacado: ");

            if (double.TryParse(Console.ReadLine(), out valor))
            {
                if (saldo >= valor)
                {
                    Console.WriteLine();
                    saldo -= valor;
                    Console.WriteLine("Saque realizado com sucesso!");
                    ConsultarSaldo();

                    log.SaqueLog(fun, valor);

                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                    ConsultarSaldo();
                }
            }
            else
            {
                Console.WriteLine("Valor inválido");
                ConsultarSaldo();
            }

        }

        public void ConsultarSaldo()
        {

            Console.WriteLine($"Seu saldo atual: {saldo}");
            Console.WriteLine();

        }

    }
}
