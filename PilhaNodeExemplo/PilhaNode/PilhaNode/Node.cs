
namespace PilhaNode
{
    public class Node<T> 
    {
        public T item;
        Node<T>? prev = null;

        public Node(T _item)
        {
            item = _item;
        }

        #pragma warning disable CS8603 // Possível retorno de referência nula.
        public Node<T> Prev { get { return prev; } }

        /// <summary>
        /// <para>
        /// Registra a referência para o nó anterior.
        /// </para>
        /// <paramref name="_prev"/> - Referência para o nó anterior.
        /// </summary>
        public void SetNext(Node<T>? _prev)
        {
            prev = _prev;
        }
    }
}
