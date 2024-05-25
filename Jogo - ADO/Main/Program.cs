using Main;

namespace Main
{ 
    class Program
    {
        public Class1 c = new Class1();

        public Interface_Inicial UI = new Interface_Inicial();
        public Jogo jogo = new Jogo();
        public Jogadas jogadas = new Jogadas();
        public int opcao;

        public static void Programa()
        {
            c.Inicio();
        }

        public void Main()
        {
            opcao = UI.Menu();
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    jogo.IniciarJogo();
                    break;
                case 2:
                    Console.WriteLine("Exibir Resumo");
                    break;
                case 3:
                    Console.WriteLine("Sair");
                    break;
            }
        }
    }

}

