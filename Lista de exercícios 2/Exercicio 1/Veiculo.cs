using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public abstract class Veiculo : IVeiculo
    {

        public static int id { get; set; }

        public abstract int idPersonal { get; set; }

        public abstract void Mover();

        public Veiculo()
        {
            if (id == 0) { id = 1; }

            idPersonal = id;
            id++;
        }

    }
}
