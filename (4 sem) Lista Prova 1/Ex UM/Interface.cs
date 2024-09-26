using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_UM;

namespace Ex_UM
{
    public class Interface
    {

        private ContaBancaria c;
        public int opcao;

        public void Inicio()
        {


            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao banco!");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

        }

        public void CriarConta()
        {
            int ID;
            double Saldo = 0;

            Console.Write("Digite o número da conta: ");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("O saldo inicial da conta é sempre em 0");
            Console.WriteLine();

            ContaBancaria conta = new ContaBancaria(ID, Saldo);
            c = conta;

            Console.WriteLine("Conta criada com sucesso!");
            Console.WriteLine();

        }

        public void Depositar()
        {
            double valor;

            Console.Write("Digite o valor a ser depositado: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine();

            c.Depositar(valor);

        }

        public void Sacar()
        {
            double valor;

            Console.Write("Digite o valor a ser sacado: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine();

            c.Sacar(valor);

        }



    }
}
