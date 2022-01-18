using DatastructureAlgorithms.Linked_Lists;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Queue
{
    public class Queues<T> where T : class
    {
        public LinkedLists<T> queue;
        public Queues()
        {
            queue = new LinkedLists<T>();
        }

        public ListNode<T> Enqueue(T value)
        {
            return queue.AddToEnd(value);
        }

        public ListNode<T> Peek()
        {
            return queue.head;
        }

        public void Dequeue()
        {
            queue.RemoveFromStart();
        }

        public int Length()
        {
            return queue.size;
        }

        public void ToList()
        {
            queue.printList();
        }
    }
}