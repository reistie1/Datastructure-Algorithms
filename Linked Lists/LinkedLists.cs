using System.Collections.Generic;
using Datastructures_LinkedList;
using System;

namespace DatastructureAlgorithms.Linked_List
{
    public class LinkedLists<T> where T : class
    {
        public ListNode<T> head;
        public ListNode<T> tail;
        public int size;
        public LinkedLists()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public ListNode<T> CreateList(T[] input_list)
        {
            int index = 0;

            do
            {
                this.InsertAtEnd(input_list[index++]);
                this.size++;
            }while(index <= input_list.Length - 1);

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

        public ListNode<T> InsertAtStart(T value)
        {
            ListNode<T> newNode = new ListNode<T>(value);

            if(this.head == null)
            {
                this.head = newNode;
                this.tail = this.head;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }

            this.size++;
            
            return this.head;
        }

        public ListNode<T> InsertAtEnd(T value)
        {
            ListNode<T> newNode = new ListNode<T>(value);
            ListNode<T> current = this.head;

            if(current == null)
            {
                this.head = newNode;
                this.tail = this.head;
                this.size++;

                return this.head;
            }

            this.tail.next = newNode;
            this.tail = newNode;
            this.size++;

            return this.tail;
        }

        public void printList()
        {
            ListNode<T> temp = this.head;
            string result = "";

            if(temp == null)
            {
                return;
            }
            
            do
            {
                result += $"{temp.value} ->"; 
                temp = temp.next;
            }while(temp != null);

            Console.WriteLine(result); 
        }

        public ListNode<T> DeleteNode(T value)
        {
            ListNode<T> prev = null;
            ListNode<T> curr = this.head;

            if(curr.value == value)
            {
                if(this.head.next == null)
                {
                    this.head = null;
                }
                else
                {
                    this.head = this.head.next;
                    curr.next = null;
                }
                return this.head;
            }

            do
            {
                prev = curr;
                curr = curr.next;
            }while(curr.value != value);

            prev.next = curr.next;
            curr.next = null;

            return this.head;
        }

        public ListNode<T> RemoveFromStart()
        {
            
            if(this.head.next != null)
            {
                var temp = this.head;
                
                this.head = this.head.next;
                temp.next = null;
                this.size--;

                return this.head;
            }

            this.size = 0;
            return this.head;
        }

        public ListNode<T> RemoveFromEnd()
        {
            
            ListNode<T> current = this.head;
            ListNode<T> prev = null;

            if(current == null)
            {
                return current;
            }

            do
            {
                prev = current;
                current = current.next;
            }while(current.next != null);

            prev.next = null;
            this.size--;

            return current;
        }

        public ListNode<T> Peek()
        {
            return this.head;
        }

        public int GetSize()
        {
            return this.size;
        }
    }
}