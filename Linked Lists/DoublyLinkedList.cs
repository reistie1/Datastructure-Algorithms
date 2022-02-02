using System;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.DoublyLinkedList
{
    public class DoublyLinkedLists<T> where T : class
    {
        public ListNode head;
        public DoublyLinkedLists()
        {
            head = null;
        }

        public ListNode  InsertAtStart(int value)
        {
            if(this.head == null)
            {
                this.head = new ListNode(value);
            }
            else
            {
                ListNode newNode = new ListNode(value);
                newNode.next = this.head;
                this.head.prev = newNode;
                this.head = newNode;
            }

            return this.head;
        }

        public int Search(int value)
        {
            ListNode current = this.head;

            if(this.head == null)
            {
                return -1;
            }

            do
            {
                current = current.next;
            }while(current != null && !current.value.Equals(value));

            
            if(current == null)
            {
                return -1;
            }

            return current.value;
        }

        public ListNode  DeleteStart()
        {
            ListNode  temp = this.head;

            this.head = this.head.next;
            this.head.prev = null;
            temp.next = null;

            return this.head;            
        }

        public ListNode InsertAtEnd(int value)
        {
            ListNode current = this.head;
            ListNode newNode = new ListNode(value);
            
            while(current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;
            
            return this.head;
        }

        public ListNode DeleteLast()
        {
            ListNode prev = null;
            ListNode curr = this.head;

            do
            {
                prev = curr;
                curr = curr.next;
            }while(curr.next != null);

            prev.next = null;
            curr.prev = null; 

            return this.head;
        }

        public ListNode InsertAfter(int value, int newvalue)
        {
            ListNode prev = null;
            ListNode curr = this.head;
            ListNode newNode = new ListNode(newvalue);

            do
            {
                prev = curr;
                curr = curr.next;
            }while(prev.value != value);

            prev.next = newNode;
            newNode.next = curr;
            newNode.prev = prev;
            curr.prev = newNode;

            return this.head;
        
        }

        public ListNode Delete(int value)
        {
            ListNode prev = null;
            ListNode curr = this.head;

            if(this.head.value == value)
            {
                this.head = this.head.next;
                this.head.prev = null;
                curr.next = null;

                return this.head;
            }

            do
            {
                prev = curr;
                curr = curr.next;
            }while(curr.value != value);

            if(curr.next == null)
            {
                prev.next = null;
                curr.prev = null;

                return this.head;
            }

            prev.next = curr.next;
            curr.next.prev = prev;
            curr.next = null;
            curr.prev = null;

            return this.head;
        }

        public void PrintForward()
        {
            ListNode temp = this.head;
            string result = "";

            while(temp != null)
            {
                result += temp.value + " -> ";
                temp = temp.next;
            }
            Console.WriteLine(result);
        }

        public void PrintInReverse()
        {
            ListNode temp = this.head;
            string result = "";

            while(temp.next != null)
            {
                temp = temp.next;
            }

            while(temp != null)
            {
                result += temp.value + " -> ";
                temp = temp.prev;
            }
            Console.WriteLine(result);
        }


    }
}