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

        public Livro Livro { get => livro; set => livro = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }

        public Emprestimo(Livro livro, Aluno aluno)
        {

            livro = this.livro;
            aluno = this.aluno;
            this.livro.isEmprestado = true;
            dataDevolucao = dataEmprestimo.AddDays(7);

            Console.WriteLine($"Livro emprestado com sucesso as {dataEmprestimo}!");

        }

    }
}
