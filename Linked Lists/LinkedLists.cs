using System.Collections.Generic;
using Datastructures_LinkedList;
using System;

namespace DatastructureAlgorithms.Linked_List
{
    public class LinkedLists
    {
        public ListNode head;
        public ListNode tail;
        public int size;
        public LinkedLists()
        {
            this.head = null;
            this.tail = this.head;
            this.size = 0;
        }

        public ListNode CreateList(int[] input_list)
        {
            int index = 0;

            do
            {
                this.AddToEnd(input_list[index++]);
                this.size++;
            }while(index <= input_list.Length - 1);

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

        public ListNode AddToStart(int value)
        {
            ListNode newNode = new ListNode(value);

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

        public ListNode AddToStart(string value)
        {
            ListNode newNode = new ListNode(value);

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

        public ListNode AddToEnd(int value)
        {
            ListNode newNode = new ListNode(value);
            ListNode current = this.head;

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

         public ListNode AddToEnd(string value)
        {
            ListNode newNode = new ListNode(value);
            ListNode current = this.head;

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
            ListNode temp = this.head;
            string result = "";
            do
            {
                result += $"{temp.otherValue} ->"; 
                temp = temp.next;
            }while(temp != null);

            Console.WriteLine(result); 
        }

        public ListNode Delete(int value)
        {
            ListNode prev = null;
            ListNode curr = this.head;

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

        public ListNode RemoveFromStart()
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

        public ListNode Peek()
        {
            return this.head;
        }
    }
}