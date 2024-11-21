using Exercicio_4;
using Exercicio_4.ConjuntoE;

Biblioteca bib = new Biblioteca();
Aluno aluno = new Aluno();

bib.AdicionarLivro();
bib.AdicionarLivro();
bib.ListarLivros();
bib.EmprestarLivro(aluno);
bib.DevolverLivro();


