using System;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.DoublyLinkedList
{
    public class DoublyLinkedLists<T> where T : class
    {
        public ListNode<T> Head;
        public DoublyLinkedLists()
        {
            Head = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T>  InsertAtStart(T Value)
        {
            if(this.Head == null)
            {
                this.Head = new ListNode<T>(Value);
            }
            else
            {
                ListNode<T> newNode = new ListNode<T>(Value);
                newNode.Next = this.Head;
                this.Head.Prev = newNode;
                this.Head = newNode;
            }

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public T Search(T Value)
        {
            ListNode<T> current = this.Head;

            if(this.Head == null)
            {
                return null;
            }

            do
            {
                current = current.Next;
            }while(current != null && !current.Value.Equals(Value));

            
            if(current == null)
            {
                return null;
            }

            return current.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T>  DeleteStart()
        {
            ListNode<T> Temp = this.Head;

            this.Head = this.Head.Next;
            this.Head.Prev = null;
            Temp.Next = null;

            return this.Head;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> InsertAtEnd(T Value)
        {
            ListNode<T> current = this.Head;
            ListNode<T> newNode = new ListNode<T>(Value);
            
            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Prev = current;
            
            return this.Head;
        }

        public ListNode<T> DeleteLast()
        {
            ListNode<T> Prev = null;
            ListNode<T> curr = this.Head;

            do
            {
                Prev = curr;
                curr = curr.Next;
            }while(curr.Next != null);

            Prev.Next = null;
            curr.Prev = null; 

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public ListNode<T> InsertAfter(T Value, T newValue)
        {
            ListNode<T> Prev = null;
            ListNode<T> curr = this.Head;
            ListNode<T> newNode = new ListNode<T>(newValue);

            do
            {
                Prev = curr;
                curr = curr.Next;
            }while(Prev.Value != Value);

            Prev.Next = newNode;
            newNode.Next = curr;
            newNode.Prev = Prev;
            curr.Prev = newNode;

            return this.Head;
        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> Delete(T Value)
        {
            ListNode<T> Prev = null;
            ListNode<T> curr = this.Head;

            if(this.Head.Value == Value)
            {
                this.Head = this.Head.Next;
                this.Head.Prev = null;
                curr.Next = null;

                return this.Head;
            }

            do
            {
                Prev = curr;
                curr = curr.Next;
            }while(curr.Value != Value);

            if(curr.Next == null)
            {
                Prev.Next = null;
                curr.Prev = null;

                return this.Head;
            }

            Prev.Next = curr.Next;
            curr.Next.Prev = Prev;
            curr.Next = null;
            curr.Prev = null;

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        public void PrintForward()
        {
            ListNode<T> Temp = this.Head;
            string result = "";

            while(Temp != null)
            {
                result += Temp.Value + " -> ";
                Temp = Temp.Next;
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// 
        /// </summary>
        public void PrintInReverse()
        {
            ListNode<T> Temp = this.Head;
            string result = "";

            while(Temp.Next != null)
            {
                Temp = Temp.Next;
            }

            while(Temp != null)
            {
                result += Temp.Value + " -> ";
                Temp = Temp.Prev;
            }
            Console.WriteLine(result);
        }


    }
}