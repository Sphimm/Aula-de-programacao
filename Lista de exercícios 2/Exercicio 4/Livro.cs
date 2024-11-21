using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_4.ConjuntoE;

namespace Exercicio_4
{
    public class Livro
    {

        private static int id = 1;

        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private ECapa capa;
        private int edicao;
        private int qPaginas;
        private EGenero genero;
        private EFormato formato;
        private EIdioma idioma;

        public int Isbn { get => isbn; private set => isbn = value; }
        public string Titulo { get => titulo; private set => titulo = value; }
        public string Autor { get => autor; private set => autor = value; }
        public string Editora { get => editora; private set => editora = value; }
        public ECapa Capa { get => capa; private set => capa = value; }
        public int Edicao { get => edicao; private set => edicao = value; }
        public int QPaginas { get => qPaginas; private set => qPaginas = value; }
        public EGenero Genero { get => genero; private set => genero = value; }
        public EFormato Formato { get => formato; private set => formato = value; }
        public EIdioma Idioma { get => idioma; private set => idioma = value; }

        public bool isEmprestado =  false;

        public Livro()
        {
            isbn = id;
            id++;
            int opcao = 1;

            Console.WriteLine("Digite o título do livro: ");
            titulo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o autor do livro: ");
            autor = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a editora do livro: ");
            editora = Console.ReadLine();
            Console.WriteLine();

            opcao = 1;
            Console.WriteLine("Digite o formato do livro: ");
            foreach (EFormato f in Enum.GetValues(typeof(EFormato)))
            {
                Console.WriteLine(f + " = " + opcao);
                opcao++;
            }
            formato = (EFormato)int.Parse(Console.ReadLine());
            Console.WriteLine();

            opcao = 1;
            Console.WriteLine("Digite o idioma do livro: ");
            foreach (EIdioma i in Enum.GetValues(typeof(EIdioma)))
            {
                Console.WriteLine(i + " = " + opcao);
                opcao++;
            }
            idioma = (EIdioma)int.Parse(Console.ReadLine());
            Console.WriteLine();

            opcao = 1;
            Console.WriteLine("Digite o tipo de capa do livro: ");
            foreach (ECapa c in Enum.GetValues(typeof(ECapa)))
            {
                Console.WriteLine(c + " = " + opcao);
                opcao++;
            }
            capa = (ECapa)int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a edição do livro: ");
            edicao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de páginas do livro: ");
            qPaginas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            opcao = 1;
            Console.WriteLine("Digite o gênero do livro: ");
            foreach (EGenero g in Enum.GetValues(typeof (EGenero)))
            {
                Console.WriteLine(g + " = " + opcao);
                opcao++;
            }
            genero = (EGenero)int.Parse(Console.ReadLine());
            Console.WriteLine();

        }

        public Livro(string titulo, string autor, string editora, int edicao, int qPaginas, EGenero genero, EFormato formato, ECapa capa, EIdioma idioma) 
        {

            isbn = id;
            id++;

            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.edicao = edicao;
            this.qPaginas = qPaginas;
            this.genero = genero;
            this.formato = formato;
            this.capa = capa;
            this.idioma = idioma;

        }
    }
}
