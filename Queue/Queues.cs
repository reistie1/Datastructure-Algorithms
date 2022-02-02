using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Queue
{
    public class Queues
    {
        public LinkedLists queue;
        public Queues()
        {
            queue = new LinkedLists();
        }

        public ListNode Enqueue(int value)
        {
            return queue.AddToEnd(value);
        }

        public ListNode Peek()
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