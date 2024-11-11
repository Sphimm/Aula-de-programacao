using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public interface IVeiculo
    {

        static int id { get; set; }

        int idPersonal { get; set; }

        void Mover();

    }
}
