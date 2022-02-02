using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Stack
{
    public class Stacks
    {
        public LinkedLists stack;
        public Stacks()
        {
            stack = new LinkedLists();
        }

        public ListNode Push(int value)
        {
            return stack.AddToStart(value);
        }

        public ListNode Peek()
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