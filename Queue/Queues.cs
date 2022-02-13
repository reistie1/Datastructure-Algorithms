using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
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

        public Queues(List<T> list)
        {
            foreach(var item in list)
            {
                queue.InsertAtEnd(item);
            }
        }

        public ListNode<T> Enqueue(T value)
        {
            return queue.InsertAtEnd(value);
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

        public bool isEmpty()
        {
            return queue.size == 0;
        }
    }
}