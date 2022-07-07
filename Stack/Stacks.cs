using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Stack
{
    public class Stacks<T> where T : class
    {
        public LinkedLists<T> Stack;
        public Stacks()
        {
            Stack = new LinkedLists<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> Push(T Value)
        {
            return Stack.InsertAtStart(Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> Peek()
        {
            return Stack.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Pop()
        {
            Stack.RemoveFromStart();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return Stack.Size;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ToList()
        {
            Stack.PrintList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return Stack.Size == 0;
        }
    }
}