using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Bicicleta : Veiculo
    {

        public override int idPersonal { get; set; }

        public override void Mover()
        {
            Console.WriteLine("Bicicleta se movendo");
        }

    }
}
