using Programa;

namespace Programa
{
    internal class Program
    {        

        static void Main(string[] args)
        {

            Jogo jogo = new Jogo();
            Interface_Inicial UI = new Interface_Inicial();

            int opcao;

            UI.BemVindo();
           
            do
            {
                opcao = UI.Menu();
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        jogo.IniciarJogo();
                        break;
                    case 2:
                        jogo.ExibirResumo();
                        break;
                    case 3:
                        jogo.Sair();
                        break;
                }
            } while (opcao != 3);
        }
    }
}