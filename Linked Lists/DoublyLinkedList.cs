using System;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.DoublyLinkedList
{
    public class DoublyLinkedLists<T> where T : class
    {
        public ListNode<T>  head;
        public DoublyLinkedLists()
        {
            head = null;
        }

        public ListNode<T>  InsertAtStart(T value)
        {
            if(this.head == null)
            {
                this.head = new ListNode<T> (value);
            }
            else
            {
                ListNode<T>  newNode = new ListNode<T> (value);
                newNode.next = this.head;
                this.head.prev = newNode;
                this.head = newNode;
            }

            return this.head;
        }

        public T Search(T value)
        {
            ListNode<T> current = this.head;

            if(this.head == null)
            {
                return null;
            }

            do
            {
                current = current.next;
            }while(current != null && !current.value.Equals(value));

            
            if(current == null)
            {
                return null;
            }

            return current.value;
        }

        public ListNode<T>  DeleteStart()
        {
            ListNode<T>  temp = this.head;

            this.head = this.head.next;
            this.head.prev = null;
            temp.next = null;

            return this.head;            
        }

        public ListNode<T>  InsertAtEnd(T value)
        {
            ListNode<T>  current = this.head;
            ListNode<T>  newNode = new ListNode<T> (value);
            
            while(current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;
            
            return this.head;
        }

        public ListNode<T>  DeleteLast()
        {
            ListNode<T>  prev = null;
            ListNode<T>  curr = this.head;

            do
            {
                prev = curr;
                curr = curr.next;
            }while(curr.next != null);

            prev.next = null;
            curr.prev = null; 

            return this.head;
        }

        public ListNode<T>  InsertAfter(T value, T newvalue)
        {
            ListNode<T>  prev = null;
            ListNode<T>  curr = this.head;
            ListNode<T>  newNode = new ListNode<T> (newvalue);

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

        public ListNode<T> Delete(T value)
        {
            ListNode<T>  prev = null;
            ListNode<T>  curr = this.head;

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
            ListNode<T>  temp = this.head;
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
            ListNode<T>  temp = this.head;
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