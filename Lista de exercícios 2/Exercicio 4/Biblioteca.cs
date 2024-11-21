using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_4;

namespace Exercicio_4
{

    public class Biblioteca
    {

        public Dictionary<int, Livro> livros = new Dictionary<int, Livro>();
        public Dictionary<int, Emprestimo> emprestimo = new Dictionary<int, Emprestimo>();

        public void AdicionarLivro()
        {

            Livro liv = new Livro();

            livros.Add(liv.Isbn, liv);

            Console.WriteLine("Livro adicionado com sucesso!");
            Console.WriteLine($"Titulo: {livros[liv.Isbn].Titulo} \nAutor: {livros[liv.Isbn].Autor}");

            Console.WriteLine();

        }

        public void EmprestarLivro(Aluno aluno)
        {

            Console.WriteLine("Livros disponíveis: ");

            foreach (var atual in livros)
            {
                if (!atual.Value.isEmprestado)
                {
                    Console.WriteLine($"ISBN: {atual.Value.Isbn} \nTitulo: {atual.Value.Titulo} \nAutor: {atual.Value.Autor}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Qual o ISBN do livro que deseja pegar emprestado?");
            int isbn = int.Parse(Console.ReadLine());

            Emprestimo emp = new Emprestimo(livros[isbn], aluno);

            emprestimo.Add(emp.EmprestimoId, emp);

            Console.WriteLine();

        }

        public void DevolverLivro()
        {

            Console.WriteLine("Emprestimos ativos: ");

            foreach (var atual in emprestimo)
            {
                if (atual.Value.Livro.isEmprestado)
                {
                    Console.WriteLine($"Código do Emprestimo: {atual.Key} \nISBN: {atual.Value.Livro.Isbn} \nTitulo: {atual.Value.Livro.Titulo} \nAutor: {atual.Value.Livro.Autor}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Qual o código do emprestimo que deseja devolver?");
            int emp = int.Parse(Console.ReadLine());

            emprestimo[emp].Livro.isEmprestado = false;
            emprestimo[emp].DataDevolucaoReal = DateTime.Now;

            Console.WriteLine($"Livro devolvido com sucesso as {emprestimo[emp].DataDevolucaoReal}!");

        }

        public void ListarLivros()
        {

            foreach (var atual in livros)
            {
                if (!atual.Value.isEmprestado)
                {
                    Console.WriteLine($"ISBN: {atual.Value.Isbn} \nTitulo: {atual.Value.Titulo} \nAutor: {atual.Value.Autor}\n");
                    Console.WriteLine("EMPRESTADO\n");
                    Console.WriteLine();
                }

                Console.WriteLine($"ISBN: {atual.Value.Isbn} \nTitulo: {atual.Value.Titulo} \nAutor: {atual.Value.Autor}\n");
                Console.WriteLine();

            }

        }

        public void StatusEmprestimo()
        {

            Console.WriteLine("Emprestimos ativos: ");

            foreach (var atual in emprestimo)
            {
                if (atual.Value.Livro.isEmprestado)
                {
                    Console.WriteLine($"Código do Emprestimo: {atual.Key} \nISBN: {atual.Value.Livro.Isbn} \nTitulo: {atual.Value.Livro.Titulo} \nAutor: {atual.Value.Livro.Autor}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Qual o código do emprestimo que deseja verificar?");
            int emp = int.Parse(Console.ReadLine());

            if (emprestimo[emp].DataDevolucao < DateTime.Now)
            {
                Console.WriteLine("Atrasado!");
            }

            else
            {
                Console.WriteLine("Dentro do prazo!");
            }

        }
    }
}
