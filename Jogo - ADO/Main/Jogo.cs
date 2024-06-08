using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa;
using static System.Net.Mime.MediaTypeNames;

namespace Programa
{
    public class Jogo
    {
        Jogadas jogadas = new Jogadas();
        Interface_Inicial UI = new Interface_Inicial();

        public string? Nome;
        public int vitoriasJ;
        public int vitoriasA;
        public int cont = 0;
        List<int> partidas = new List<int>();

        public void IniciarJogo()
        {
            UI.Linha();
            Console.WriteLine();

            Console.WriteLine("Iniciando Jogo");
            NomeJogador();
            Jogar();
            Vitoria();

            UI.Linha();
            Console.WriteLine();
        }

        public void NomeJogador()
        {            
            Console.WriteLine();

            Console.Write("Digite o seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("O nome do jogador é: " + Nome);

            Console.WriteLine();
        }

        public void Jogar()
        {           

            do
            {
                if (!MelhorDeTres())
                {
                    cont++;
                    partidas.Add(cont);
                }

                jogadas.Add(Escolha());
                jogadas.Random();
                jogadas.Comparação();
                Placar();

            } while (!MelhorDeTres());
            
        }

        private bool MelhorDeTres()
        {
            
            if (jogadas.jogadorPoint == 3)
            {
                return true;
            }

            else if (jogadas.adversarioPoint == 3)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        private void Placar()
        {
            Console.WriteLine();
            Console.Write("| Placar: ");
            Console.WriteLine($"{Nome.ToUpper()} - {jogadas.jogadorPoint} X ADVERSÁRIO - {jogadas.adversarioPoint} |");
            Console.WriteLine();
        }

        private void Vitoria()
        {
            if (jogadas.jogadorPoint == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Você venceu!");
                Console.WriteLine();

                vitoriasJ++;
                jogadas.jogadorPoint = 0;
            }
            else if (jogadas.adversarioPoint == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Você perdeu!");
                Console.WriteLine();

                vitoriasA++;
                jogadas.adversarioPoint = 0;
            }


        }

        public int Escolha()
        {
            int opcao;
            UI.Mlinha();
            Console.WriteLine();

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();

            for (int i = 0; i < jogadas.Opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {jogadas.Opcoes[i]}");
            }

            opcao = ReadOut();

            return opcao;
        }

        private int ReadOut()
        {
            string? entrada = Read();
            int opcao = ValidarEntrada(entrada);
            return opcao;
        }

        private string? Read()
        {
            Console.WriteLine();
            Console.Write("Digite aqui: ");

            string? entrada = Console.ReadLine();
            return entrada;
        }

        private int ValidarEntrada(string? entrada)
        {
            int opcao;

            while (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida (A entrada não foi numérica). Tente novamente.");
                entrada = Read();
            }

            while (!(opcao >= 0 && opcao < 3))
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida (A entrada não está entre 0 e 2). Tente novamente.");
                return ValidarEntrada(Read());

            }

            return opcao;

        }

        public void ExibirResumo()
        {
            

            if (File.Exists("Arquivo\\teste.txt"))  // Verificar se o arquivo existe
            {
                UI.Linha();
                Console.WriteLine();

                Console.WriteLine("Exibindo Resumo");

                string pat = Path.GetFullPath("Arquivo\\teste.txt");
                string linhas = File.ReadAllText(pat);
                Console.WriteLine(linhas);
                
            }

            else
            {
                Console.WriteLine("Nenhum jogo foi salvo ainda");
            }

            Console.WriteLine();
        }

        private void SalvarJogo()
        {            

            Console.WriteLine("Salvando Jogo...");
            Console.WriteLine();
            
            string path = Path.GetFullPath("Arquivo");
            Console.WriteLine(path);
            string arquivo = string.Concat(path, Path.DirectorySeparatorChar, "teste.txt");
            if (!File.Exists(arquivo))
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(string.Concat(path));
                }

                File.Create(string.Concat(path, Path.DirectorySeparatorChar, "teste.txt")).Close();
            }

            string jogoSalvo = $"{Environment.NewLine}===================================";
            File.AppendAllText(arquivo, jogoSalvo);

            for (int i = 0; i < partidas.Count; i++)
            {
                
                string jogoSalvo1 = $"{Environment.NewLine}\nPartida {partidas[i]}:{Environment.NewLine}" +
                    $"Jogada de {Nome}: {jogadas.jogadorNum[i]} - {jogadas.Opcoes[jogadas.jogadorNum[i]]} {Environment.NewLine}" +
                    $"Jogada do computador: {jogadas.randomNum[i]} - {jogadas.Opcoes[jogadas.randomNum[i]]}";
                File.AppendAllText(arquivo, jogoSalvo1);
            }
            string jogoSalvo2 = $"{Environment.NewLine}\nTotal de Vitorias de {Nome}: {vitoriasJ}\n {Environment.NewLine}Total de Vitorias do Adversário: {vitoriasA}\n";
            File.AppendAllText(arquivo, jogoSalvo2);

            string jogoSalvo3 = $"{Environment.NewLine}===================================";
            File.AppendAllText(arquivo, jogoSalvo3);

            Console.WriteLine();
            Console.WriteLine("Jogo salvo com sucesso");
            Console.WriteLine();
        }

        public void Sair()
        {
            UI.Linha();
            Console.WriteLine();

            Console.WriteLine("Saindo");
            Console.WriteLine();

            int salvar = DesejaSalvar();

            if (salvar == 1)
            {
                SalvarJogo();
            }

            else if (salvar == 0)
            {
                Console.WriteLine("Saindo sem Salvar...");
                Console.WriteLine();
            }

            UI.Linha();
            Console.WriteLine();

        }

        private int DesejaSalvar()
        {
            UI.Mlinha();
            Console.WriteLine();

            Console.Write("Deseja salvar o jogo antes de sair? (S/N): ");
            string salvar = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (salvar == "S")
            {
                UI.Mlinha();
                Console.WriteLine();

                return 1;
            }

            else if (salvar == "N") 
            {
                UI.Mlinha();
                Console.WriteLine();

                return 0;
            }

            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.WriteLine();

                DesejaSalvar();

                return 2;
            }


        }
    }
}
