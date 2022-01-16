using System;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.DoublyLinkedList
{
    public class DoublyLinkedLists
    {
        public ListNode head;
        public DoublyLinkedLists()
        {
            head = null;
        }

        public ListNode InsertAtStart(int val)
        {
            if(this.head == null)
            {
                this.head = new ListNode(val);
            }
            else
            {
                ListNode newNode = new ListNode(val);
                newNode._next = this.head;
                this.head._prev = newNode;
                this.head = newNode;
            }

            return this.head;
        }

        public ListNode DeleteStart()
        {
            ListNode temp = this.head;

            this.head = this.head._next;
            this.head._prev = null;
            temp._next = null;

            return this.head;            
        }

        public ListNode InsertAtEnd(int val)
        {
            ListNode current = this.head;
            ListNode newNode = new ListNode(val);
            
            while(current._next != null)
            {
                current = current._next;
            }

            current._next = newNode;
            newNode._prev = current;
            
            return this.head;
        }

        public ListNode DeleteLast()
        {
            ListNode prev = null;
            ListNode curr = this.head;

            do
            {
                prev = curr;
                curr = curr._next;
            }while(curr._next != null);

            prev._next = null;
            curr._prev = null; 

            return this.head;
        }

        public ListNode InsertAfter(int val, int newVal)
        {
            ListNode prev = null;
            ListNode curr = this.head;
            ListNode newNode = new ListNode(newVal);

            do
            {
                prev = curr;
                curr = curr._next;
            }while(prev._val != val);

            prev._next = newNode;
            newNode._next = curr;
            newNode._prev = prev;
            curr._prev = newNode;

            return this.head;
        
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void PrintForward()
        {
            ListNode temp = this.head;
            string result = "";

            while(temp != null)
            {
                result += temp._val + " -> ";
                temp = temp._next;
            }
            Console.WriteLine(result);
        }

        public void PrintInReverse()
        {
            throw new NotImplementedException();
        }


    }
}