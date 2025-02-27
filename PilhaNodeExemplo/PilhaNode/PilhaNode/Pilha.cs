
namespace PilhaNode
{
    public class Pilha<T>
    {
        Node<T>? top;
        int size;

        /// <summary>
        /// <para>
        /// Cria a pilha com 1 elemento
        /// </para>
        /// <paramref name="top"/> Primeiro nó da fila, também será o topo.
        /// </summary>
        public Pilha(Node<T> top)
        {
            Push(top);
        }
        /// <summary>
        /// <para>
        /// Cria uma pilha vazia
        /// </para>
        /// </summary>
        public Pilha()
        {
            size = 0;
        }
        /// <summary>
        /// <para>
        /// Adiciona um item no topo da pilha.
        /// </para>
        /// <para>
        /// Se a pilha já possuir um topo, será adicionada areferência para nó anterior no novo topo
        /// </para>
        /// <paramref name="node"/> item a ser incluído no topo da pilha
        /// </summary>
        public void Push(Node<T> node)
        {
            if (top != null)
                node.SetNext(top);

            top = node;

            size++;
        }
        /// <summary>
        /// <para>Se a pilha estiver vazia retornará null</para>
        /// <para>Retorna o topo da pilha. <strong>E</strong> remove o item da pilha!</para>
        /// <para>Se após remover o topo a pilha ficar vazia, a pilha ficará com status de vazia</para>
        /// </summary>
        /// <returns><code>Node</code> item referente ao topo da pilha</returns>
        public Node<T>? Pop()
        {
            if (size <= 0)
            {
                return null;
            }

            var temp = top;

            size--;
            
            top = temp.Prev;

            return temp;
        }
        /// <summary>
        /// <para>Retorna o topo da pilha.</para>
        /// <para>NÃO REMOVE da pilha</para>
        /// </summary>
        /// <returns></returns>
        public Node<T>? Peek()
        {
            return top;
        }

        /// <summary>
        /// Verifica se a pilha está vazia
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => size == 0;

        /// <summary>
        /// Retorna o total de itens na pilha
        /// </summary>
        /// <returns></returns>
        public int Count { get { return size; } }
    }
}
