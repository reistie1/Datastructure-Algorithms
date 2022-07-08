using Datastructures_LinkedList;
using System;

namespace DatastructureAlgorithms.DoublyLinkedList
{
    public class DoublyLinkedList<T> where T : class
    {
        public ListNode<T> Head;
        public ListNode<T> Tail;
        public int size;
        public DoublyLinkedList()
        {
            this.Head = this.Tail = null;
            this.size = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public ListNode<T> CreateList(T[] List)
        {
            for(int i = 0; i < List.Length; i++)
            {
                this.InsertEnd(List[i++]);
                this.size++;
            }

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> Get(T Value)
        {
            ListNode<T> Current = this.Head;

            if(Current == null)
            {
                return null;
            }

            if(Current.Value == Value)
            {
                return Current;
            }
            else
            {
                do
                {
                    Current = Current.Next;
                }while(Current != null && !Current.Value.Equals(Value));

                return Current;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool Contains(T Value)
        {
            ListNode<T> Current = this.Head;

            if(Current == null)
                return false;

            do
            {
                Current = Current.Next;
            }while(Current != null && !Current.Value.Equals(Value));

            return true;
        }

        public ListNode<T> InsertStart(T Value)
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

            this.size++;
            
            return this.Head;
        }

        public ListNode<T> InsertEnd(T Value)
        {
            ListNode<T> NewNode = new ListNode<T>(Value);
            ListNode<T> Current = this.Head;

            if(Current == null)
            {
                this.Head = this.Tail = NewNode;
            }
            else
            {
                NewNode.Prev = this.Tail;
                this.Tail = NewNode;
            }

            this.size++;

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Print()
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

        public void Update(T Value, T NewValue)
        {
            if(this.Contains(Value))
            {
                ListNode<T> Curr = this.Get(Value);

                Curr.Value = NewValue;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<T> Delete(T Value)
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
                    this.Head.Next.Prev = null;
                    Curr.Next = null;
                }
                this.size--;
                return this.Head;
            }

            do
            {
                Prev = Curr;
                Curr = Curr.Next;
            }while(Curr.Value != Value);

            Prev.Next = Curr.Next;
            Curr.Next.Prev = Prev;
            Curr.Next = Curr.Prev = null;

            this.size--;

            return this.Head;
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
        public int Size()
        {
            return this.size;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.Head == null || this.Tail == null ? true : false;
        }
    }
}