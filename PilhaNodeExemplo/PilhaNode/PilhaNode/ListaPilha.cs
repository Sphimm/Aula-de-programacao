
namespace PilhaNode
{
    public class ListaPilha
    {
        public Pilha<T> CriarPilha<T>(T[] values)
        {
            Pilha<T> minhaPilha = new Pilha<T>();
            foreach (T i in values)
            {
                //Criando a pilha já passando o primeiro item
                minhaPilha.Push(new Node<T>(i));
            }

            return minhaPilha;
        }

        public void ShowPilha(Node<int> top)
        {
            Node<int>? temp = top;
            int count = 0;
            while(temp != null)
            {
                Console.WriteLine("Item: {0} - {1}", (count > 0 ? count : "TOPO"), temp.item);
                temp = temp.Prev;
            }

            Console.WriteLine("Fim da Pilha");
        }
    }
}
