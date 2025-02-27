using PilhaNode;

namespace PilhaNode
{
    public class ExemploPilha
    {
        public void ExemploPushPop()
        {
            //Criando o primeiro item da pilha
            Node<int> item = new Node<int>(2);
            //Criando a pilha já passando o primeiro item
            Pilha<int> minhaPilha = new Pilha<int>(item);

            Console.WriteLine("Pilha criada!");
            Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);
            Console.WriteLine("Topo da pilha: {0}", minhaPilha.Peek()?.item);
            Console.WriteLine("Removendo o topo da pilha: {0}", minhaPilha.Pop()?.item);
            Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);

            Console.WriteLine("Adicionando a sequência de itens {3, 9, 6}");

            minhaPilha.Push(new Node<int>(3));
            minhaPilha.Push(new Node<int>(9));
            minhaPilha.Push(new Node<int>(6));

            Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);
            Console.WriteLine("Topo da pilha: {0}", minhaPilha.Peek()?.item);
            Console.WriteLine("Removendo o topo da pilha: {0}", minhaPilha.Pop()?.item);
            Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);

            Console.WriteLine("Removendo o topo da pilha: {0}", minhaPilha.Pop()?.item);
            Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);

            if (minhaPilha.Count > 0)
            {
                Console.WriteLine("Removendo o topo da pilha: {0}", minhaPilha.Pop()?.item);
                Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }


            if (minhaPilha.Peek() == null)
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                Console.WriteLine("Removendo o topo da pilha: {0}", minhaPilha.Pop()?.item);
                Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);
            }
        }
    }
}
