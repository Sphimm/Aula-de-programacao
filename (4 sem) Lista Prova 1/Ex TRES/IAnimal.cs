using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_QUATRO
{
    public interface IAnimal
    {

        public string Name { get; set; }

        public void Comer();

        public void Dormir();

        public void vocalizar();

    }
}
