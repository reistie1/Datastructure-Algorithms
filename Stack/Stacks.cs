using System.Collections.Generic;
using DatastructureAlgorithms.Linked_Lists;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Stack
{
    public class Stacks
    {
        public LinkedLists _stack;
        public Stacks()
        {
            _stack = new LinkedLists();
        }

        public ListNode push(int val)
        {
            return _stack.AddToStart(val);
        }

        public ListNode Peek()
        {
            return _stack._head;
        }


        public void pop()
        {
            _stack.RemoveFromHead();
        }

        public int length()
        {
            return _stack._size;
        }

        public void printStack()
        {
            _stack.printList();
        }
    }
}