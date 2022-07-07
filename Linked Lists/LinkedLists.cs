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
            this.Head = this.Tail = null;
            this.Size = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
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
        public ListNode<T> Search(T Value)
        {
            ListNode<T> Current = this.Head;

            if(Current == null)
            {
                return null;
            }

            do
            {
                Current = Current.Next;
            }while(Current != null && !Current.Value.Equals(Value));

            return Current;
        }

        public bool Find(T Value)
        {
            ListNode<T> Current = this.Head;

            if(Current == null)
            {
                return false;
            }

            do
            {
                Current = Current.Next;
            }while(Current != null && !Current.Value.Equals(Value));

            return true;
        }

        public ListNode<T> InsertAtStart(T Value)
        {
            ListNode<T> NewNode = new ListNode<T>(Value);

            if(this.Head == null)
            {
                this.Head = this.Tail = NewNode;
            }
            else
            {
                NewNode.Next = this.Head;
                this.Head = NewNode;
            }

            this.Size++;
            
            return this.Head;
        }

        public ListNode<T> InsertAtEnd(T Value)
        {
            ListNode<T> NewNode = new ListNode<T>(Value);
            ListNode<T> Current = this.Head;

            if(Current == null)
            {
                this.Head = this.Tail = NewNode;
                this.Size++;

                return this.Tail;
            }

            this.Tail.Next = NewNode;
            this.Tail = NewNode;
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
                result += $"{Temp.Value} -> "; 
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
            ListNode<T> Curr = this.Head;

            if(Curr.Value == Value)
            {
                if(this.Head.Next == null)
                {
                    this.Head = null;
                }
                else
                {
                    this.Head = this.Head.Next;
                    Curr.Next = null;
                }
                this.Size--;
                return this.Head;
            }

            do
            {
                Prev = Curr;
                Curr = Curr.Next;
            }while(Curr.Value != Value);

            Prev.Next = Curr.Next;
            Curr.Next = null;
            this.Size--;

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
            else
            {
                this.Head = null;
                this.Size = 0;
            }

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<T> RemoveFromEnd()
        {
            
            ListNode<T> Current = this.Head;
            ListNode<T> Prev = null;

            if(Current == null)
            {
                return Current;
            }
            
            do
            {
                Prev = Current;
                Current = Current.Next;
            }while(Current.Next != null);

            Prev.Next = null;
            this.Tail = Prev;
            this.Size--;

            return Current;
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