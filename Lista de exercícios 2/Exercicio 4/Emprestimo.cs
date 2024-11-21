using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    public class Emprestimo
    {

        private Livro livro;
        private Aluno aluno;
        private DateTime dataEmprestimo = DateTime.Now;
        private DateTime dataDevolucao;
        private DateTime dataDevolucaoReal;
        private static int id = 1;
        private int emprestimoId = id;

        public Livro Livro { get => livro; set => livro = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        public DateTime DataEmprestimo { get => dataEmprestimo; set => dataEmprestimo = value; }
        public DateTime DataDevolucao { get => dataDevolucao; set => dataDevolucao = value; }
        public DateTime DataDevolucaoReal { get => dataDevolucaoReal; set => dataDevolucaoReal = value; }
        public int EmprestimoId { get => emprestimoId; set => emprestimoId = value; }

        public Emprestimo(Livro livro, Aluno aluno)
        {

            emprestimoId = id;
            id++;

            int dias;
            this.livro = livro;
            this.aluno = aluno;
            
            Console.WriteLine("Qual o prazo de empréstimo do livro?");
            dias = int.Parse(Console.ReadLine());
            DataDevolucao = DataEmprestimo.AddDays(dias);

            this.livro.isEmprestado = true;
            Console.WriteLine($"Livro emprestado com sucesso as {DataEmprestimo}!");
            Console.WriteLine($"Data de devolução: {DataDevolucao}");
            Console.WriteLine($"Código do emprestimo: {emprestimoId}");

        }

    }
}
