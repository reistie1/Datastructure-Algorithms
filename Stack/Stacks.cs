using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Stack
{
    public class Stacks<T> where T : class
    {
        public LinkedLists<T> stack;
        public Stacks()
        {
            stack = new LinkedLists<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ListNode<T> Push(T value)
        {
            return stack.InsertAtStart(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> Peek()
        {
            return stack.head;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Pop()
        {
            stack.RemoveFromStart();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return stack.size;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ToList()
        {
            stack.printList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return stack.size == 0;
        }
    }
}