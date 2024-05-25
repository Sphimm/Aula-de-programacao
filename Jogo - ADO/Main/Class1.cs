using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main;

namespace Main
{
    internal class Class1 : Program
    {        
        int opcao;

        public void Inicio()
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
