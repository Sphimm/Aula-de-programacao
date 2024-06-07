using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa;

namespace Programa
{
    public class Inicializacoes
    {
        private Interface_Inicial UI;
        private Jogo jogo;
        private Jogadas jogadas;
        public int opcao;

        public Inicializacoes()
        {
            jogo = new Jogo(UI);
            jogadas = new Jogadas(jogo, UI);
            UI = new Interface_Inicial();
        }

        public Jogo GetJogo()
        {
            return jogo;
        }

        public void SetJogo(Jogo value)
        {
            jogo = value;
        }

        public Jogadas GetJogadas()
        {
            return jogadas;
        }

        public void SetJogadas(Jogadas value)
        {
            jogadas = value;
        }

        public Interface_Inicial GetUI()
        {
            return UI;
        }

        public void SetUI(Interface_Inicial value)
        {
            UI = value;
        }


    }
}
