using System.Collections.Generic;
using DatastructureAlgorithms.PriorityItem;
using DatastructureAlgorithms.PriorityLinkedList;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Queue
{
    public class PriorityQueues<T> where T : class
    {
        public PriorityLinkedLists<T> Queue;
        public PriorityQueues()
        {
            Queue = new PriorityLinkedLists<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        public PriorityQueues(PriorityItem<T>[] List)
        {
            Queue = new PriorityLinkedLists<T>();

            foreach(var item in List)
            {
                Queue.Insert(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public void Enqueue(PriorityItem<T> Value)
        {
            Queue.Insert(Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<PriorityItem<T>> Peek()
        {
            return Queue.Peek();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>    
        public PriorityItem<T> Dequeue()
        {
            return Queue.RemoveStart();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return Queue.Size();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Print()
        {
            Queue.Print();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Queue.Size() == 0;
        }
    }
}