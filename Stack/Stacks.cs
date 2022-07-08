using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Stack
{
    public class Stacks<T> where T : class
    {
        private LinkedLists<T> Stack;
        public Stacks()
        {
            Stack = new LinkedLists<T>();
        }

        public Stacks(T[] List)
        {
            Stack = new LinkedLists<T>();

            for(var i = 0; i < List.Length; i++)
            {
                Stack.InsertStart(List[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> Push(T Value)
        {
            return Stack.InsertStart(Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> Peek()
        {
            return Stack.Peek();
        }

        /// <summary>
        /// 
        /// </summary>
        public T Pop()
        {
            return Stack.RemoveStart();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return Stack.Size();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Print()
        {
            Stack.Print();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Stack.Size() == 0;
        }
    }
}