using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Queue
{
    public class Queues<T> where T : class
    {
        public LinkedLists<T> Queue;
        public Queues()
        {
            Queue = new LinkedLists<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        public Queues(List<T> List)
        {
            Queue = new LinkedLists<T>();

            foreach(var item in List)
            {
                Queue.InsertAtEnd(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> Enqueue(T Value)
        {
            return Queue.InsertAtEnd(Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> Peek()
        {
            return Queue.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>    
        public T DeQueue()
        {
            return Queue.RemoveFromStart().Value;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return Queue.Size;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ToList()
        {
            Queue.PrintList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Queue.Size == 0;
        }
    }
}