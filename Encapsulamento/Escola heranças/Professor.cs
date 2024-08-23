using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_heranças
{
    public class Professor : Escola
    {

        private string materia;
        private float carga_horaria;
        private int periodo;

        public bool marcar_presenca()
        {

            int entrada;
            bool Presenca;

            Console.WriteLine("Você estava na aula? ");
            Console.WriteLine();
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.WriteLine();
            entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1:
                    Presenca = true;
                    break;
                default:
                    Presenca = false;
                    break;
            }

            return presenca = Presenca;
        }



    }
}
