using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Queue
{
    public class PriorityQueues<T> where T : class
    {
        public LinkedLists<T> queue;
        public PriorityQueues()
        {
            queue = new LinkedLists<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public PriorityQueues(List<T> list)
        {
            queue = new LinkedLists<T>();

            foreach(var item in list)
            {
                queue.InsertAtEnd(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ListNode<T> Enqueue(T value)
        {
            return queue.InsertAtEnd(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> Peek()
        {
            return queue.head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>    
        public T Dequeue()
        {
            return queue.RemoveFromStart().value;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return queue.size;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ToList()
        {
            queue.printList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return queue.size == 0;
        }
    }
}