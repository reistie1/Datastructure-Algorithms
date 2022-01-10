using DatastructureAlgorithms.Linked_Lists;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Queue
{
    public class Queues
    {
        public LinkedLists _queue;
        public Queues()
        {
            _queue = new LinkedLists();
        }

        public ListNode enqueue(int val)
        {
            return _queue.AddToEnd(val);
        }

        public ListNode peek()
        {
            return _queue._head;
        }

        public void dequeue()
        {
            _queue.RemoveFromHead();
        }

        public int length()
        {
            return _queue._size;
        }

        public void printQueue()
        {
            _queue.printList();
        }
    }
}