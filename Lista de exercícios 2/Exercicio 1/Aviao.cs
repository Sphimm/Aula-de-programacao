using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Aviao : Veiculo
    {

        public override int idPersonal { get; set; }

        public override void Mover()
        {
            Console.WriteLine("Aviao se movendo");
        }

    }
}
