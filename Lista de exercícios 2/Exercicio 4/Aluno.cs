using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    public class Aluno
    {
        private static int matr = 1;

        public int matricula { get; private set; }

        public Aluno()
        {
            matricula = matr;
            matr++;
        }

    }
}
