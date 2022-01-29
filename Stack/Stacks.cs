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

        public ListNode<T> Push(T value)
        {
            return stack.AddToStart(value);
        }

        public ListNode<T> Peek()
        {
            return stack.head;
        }


        public void Pop()
        {
            stack.RemoveFromStart();
        }

        public int Length()
        {
            return stack.size;
        }

        public void ToList()
        {
            stack.printList();
        }
    }
}