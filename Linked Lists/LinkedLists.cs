using System.Collections.Generic;
using Datastructures_LinkedList;
using System;

namespace DatastructureAlgorithms.Linked_Lists
{
    public class LinkedLists<T> where T : class
    {
        public ListNode<T> head;
        public ListNode<T> tail;
        public int size;
        public LinkedLists()
        {
            this.head = null;
            this.tail = this.head;
            this.size = 0;
        }

        public ListNode<T> CreateList(T[] input_list)
        {
            int index = 0;

            do
            {
                this.AddToEnd(input_list[index++]);
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

        public ListNode<T> AddToStart(T value)
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

        public ListNode<T> AddToEnd(T value)
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

            return this.head;
        }

        public void printList()
        {
            ListNode<T> temp = this.head;
            string result = "";
            do
            {
                result += $"{temp.value.ToString()} ->"; 
                temp = temp.next;
            }while(temp != null);

            Console.WriteLine(result); 
        }

        public ListNode<T> Delete(T value)
        {
            ListNode<T> prev = null;
            ListNode<T> curr = this.head;

            if(curr.value == value)
            {
                this.head = this.head.next;
                curr.next = null;
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
            ListNode<T> temp = this.head.next;
            this.head.next = null;
            this.head = temp;

            return this.head;
        }
    }
}