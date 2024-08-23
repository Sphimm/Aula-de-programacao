using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_heranças
{
    public class Escola
    {

        protected string nome;
        protected bool presenca;

        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
