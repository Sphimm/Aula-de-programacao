using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class Funcionario
    {

        private static int funcionarioId = 1;
        private string nome;

        public int fId 
        { get; private set; }

        public string Nome
        { get => nome; private set => nome = value; }

        public Funcionario()
        {

            fId = funcionarioId;
            funcionarioId++;

            Console.Write("Informe o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Funcionario: {nome} ID: ({fId}) criado");
            Console.WriteLine();

        }

    }
}
