using Datastructures_LinkedList;
using System;

namespace DatastructureAlgorithms.Linked_List
{
    public class LinkedLists<T> where T : class
    {
        public ListNode<T> Head;
        public ListNode<T> Tail;
        public int Size;
        public LinkedLists()
        {
            this.Head = null;
            this.Tail = null;
            this.Size = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input_List"></param>
        /// <returns></returns>
        public ListNode<T> CreateList(T[] List)
        {
            int index = 0;

            do
            {
                this.InsertAtEnd(List[index++]);
                this.Size++;
            }while(index <= List.Length - 1);

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public T Search(T Value)
        {
            ListNode<T> Current = this.Head;

            if(this.Head == null)
            {
                return null;
            }

            do
            {
                Current = Current.Next;
            }while(Current != null && !Current.Value.Equals(Value));

            
            if(Current == null)
            {
                return null;
            }

            return Current.Value;
        }

        public ListNode<T> InsertAtStart(T Value)
        {
            ListNode<T> newNode = new ListNode<T>(Value);

            if(this.Head == null)
            {
                this.Head = newNode;
                this.Tail = this.Head;
            }
            else
            {
                newNode.Next = this.Head;
                this.Head = newNode;
            }

            this.Size++;
            
            return this.Head;
        }

        public ListNode<T> InsertAtEnd(T Value)
        {
            ListNode<T> newNode = new ListNode<T>(Value);
            ListNode<T> current = this.Head;

            if(current == null)
            {
                this.Head = newNode;
                this.Tail = this.Head;
                this.Size++;

                return this.Head;
            }

            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Size++;

            return this.Tail;
        }

        /// <summary>
        /// 
        /// </summary>
        public void PrintList()
        {
            ListNode<T> Temp = this.Head;
            string result = "";

            if(Temp == null)
            {
                return;
            }
            
            do
            {
                result += $"{Temp.Value} ->"; 
                Temp = Temp.Next;
            }while(Temp != null);

            Console.WriteLine(result); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> DeleteNode(T Value)
        {
            ListNode<T> Prev = null;
            ListNode<T> curr = this.Head;

            if(curr.Value == Value)
            {
                if(this.Head.Next == null)
                {
                    this.Head = null;
                }
                else
                {
                    this.Head = this.Head.Next;
                    curr.Next = null;
                }
                return this.Head;
            }

            do
            {
                Prev = curr;
                curr = curr.Next;
            }while(curr.Value != Value);

            Prev.Next = curr.Next;
            curr.Next = null;

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> RemoveFromStart()
        {
            
            if(this.Head.Next != null)
            {
                var Temp = this.Head;
                
                this.Head = this.Head.Next;
                Temp.Next = null;
                this.Size--;

                return this.Head;
            }

            this.Size = 0;
            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> RemoveFromEnd()
        {
            
            ListNode<T> current = this.Head;
            ListNode<T> Prev = null;

            if(current == null)
            {
                return current;
            }

            do
            {
                Prev = current;
                current = current.Next;
            }while(current.Next != null);

            Prev.Next = null;
            this.Size--;

            return current;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> Peek()
        {
            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return this.Size;
        }
    }
}