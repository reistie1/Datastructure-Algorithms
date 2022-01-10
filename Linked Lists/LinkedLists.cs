using Datastructures_LinkedList;
using System;

namespace DatastructureAlgorithms.Linked_Lists
{
    public class LinkedLists
    {
        public ListNode _head;
        public ListNode _tail;
        public int _size;
        public LinkedLists()
        {
            this._head = null;
            this._tail = this._head;
            this._size = 0;
        }

        public LinkedLists(ListNode head)
        {
            this._head = head;
            this._tail = this._head;
            this._size = 0;
        }

        public ListNode CreateList(int[] input_list)
        {
            int index = 0;

            do
            {
                this.InsertInOrder(input_list[index++]);
                this._size += 1;
            }while(index <= input_list.Length - 1);

            return this._head;
        }

        public ListNode AddToStart(int value)
        {
            ListNode newNode = new ListNode(value);

            if(this._head == null)
            {
                this._head = newNode;
                this._tail = this._head;

                return this._head;

            }

            newNode._next = this._head;

            this._size += 1;
            this._head = newNode;

            return this._head;
        }

        public ListNode InsertInOrder(int value)
        {
            ListNode prev = null;
            ListNode curr = null;
            ListNode newNode = new ListNode(value);


            if(this._head == null)
            {
                this._head = newNode;
                this._tail = this._head;
            }

            prev = this._head;

            do
            {
                if(newNode._val < this._head._val)
                {
                    newNode._next = this._head;
                    this._head = newNode;
                }

                if(newNode._val > this._tail._val)
                {
                    this._tail._next = newNode;
                    this._tail = newNode;
                }

                if(newNode._val > prev._val)
                {
                    curr = prev._next;

                    if(newNode._val < curr._val)
                    {
                        prev._next = null;
                        prev._next = newNode;
                        newNode._next = curr;
                    }
                }

                prev = prev._next;
            }while(prev != null);

            return this._head;
        }

        public ListNode AddToEnd(int value)
        {
            ListNode newNode = new ListNode(value);

            if(this._tail == null)
            {
                this._tail = newNode;
                this._head = newNode;
            }
            else
            {
                this._tail._next = newNode;
                this._tail = newNode;
            }
            
            this._size += 1;


            return this._head;
        }

        public void printList()
        {
            ListNode temp = this._head;
            string result = "";
            do
            {
                result += $"{temp._val} ->";
                temp = temp._next;
            }while(temp != null);

            Console.WriteLine(result);
        }

        public ListNode Delete(int val)
        {
            ListNode temp1 = this._head;
            ListNode temp2 = this._head._next;

            if(this._head._val == val)
            {
                this._head._next = null;
                this._head = temp2;

                return this._head;
            }

            do
            {
                temp2 = temp2._next;
                temp1 = temp1._next;
            }while(temp2._val != val);

            temp1._next = temp2._next;
            temp2._next = null;

            return this._head;
        }

        public ListNode RemoveFromHead()
        {
            ListNode temp = this._head._next;
            this._head._next = null;
            this._head = temp;

            return this._head;
        }
    }
}