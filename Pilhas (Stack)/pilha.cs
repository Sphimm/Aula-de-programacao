using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas__Stack_
{
    public class Stack
    {
        Stack<string> pilha {  get; set; }

        public void Criar_Stack()
        {
        pilha = new Stack<string>();
        }

        public void Add_Stack(string item)
        {
            pilha.Push(item);
        }

        public void Clear_Stack()
        {
            pilha.Clear();
        }

        public void Spy_Stack()
        {
            pilha.Peek();
        }

        public void View_Stack()
        {
            pilha.();
        }











    }
}
