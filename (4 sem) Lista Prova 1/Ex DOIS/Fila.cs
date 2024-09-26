using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_DOIS;

namespace Ex_DOIS
{
    public class Fila<T> where T : Veiculo
    {

        private List<T> lista;

        public Fila()
        {
            lista = new List<T>();

            Console.WriteLine("Fila criada");
            Console.WriteLine();
        }

        public void Inserir(T obj)
        {
            lista.Add(obj);

            Console.WriteLine("Elemento inserido na fila");
            Console.WriteLine();
        }

        public void Remover()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Fila vazia");
                Console.WriteLine();
            }
            else
            {
                lista.RemoveAt(0);

                Console.WriteLine("Elemento removido da fila");
                Console.WriteLine();
            }
        }

        public void Listar()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Fila vazia");
                Console.WriteLine();
            }
            else
            {
                foreach (T obj in lista)
                {
                    Console.WriteLine(obj.Modelo);
                    Console.WriteLine();
                    obj.Acelerar();

                }
                Console.WriteLine();
            }
        }

    }
}
