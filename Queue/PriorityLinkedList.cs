using Datastructures_LinkedList;
using System;
using DatastructureAlgorithms.PriorityItem;


namespace DatastructureAlgorithms.PriorityLinkedList
{
    public class PriorityLinkedLists<T> where T : PriorityItem<T>
    {
        private ListNode<PriorityItem<T>> Head;
        private ListNode<PriorityItem<T>> Tail;
        private int size;
        public PriorityLinkedLists()
        {
            this.Head = this.Tail = null;
            this.size = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public ListNode<PriorityItem<T>> CreateList(PriorityItem<T>[] List)
        {
            for(int i = 0; i < List.Length; i++)
            {
                this.Insert(List[i]);
                this.size++;
            }

            return this.Head;
        }

        public void Insert(PriorityItem<T> NewItem)
        {
            ListNode<PriorityItem<T>> Curr = this.Head;
            ListNode<PriorityItem<T>> Prev = null;
            ListNode<PriorityItem<T>> NewNode = new ListNode<PriorityItem<T>>(NewItem);

            if(Curr == null)
            {
                Curr = NewNode;
                this.Head = this.Tail = Curr;
            }
            
            do
            {
                Prev = Curr;
                Curr = Curr.Next;
            }while(Curr.Next != null && Curr.Value.Priority < NewItem.Priority);

            Prev.Next = NewNode;
            NewNode.Next = Curr;
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<PriorityItem<T>> Get(PriorityItem<T> Value)
        {
            ListNode<PriorityItem<T>> Current = this.Head;

            if(Current == null)
                return null;

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

        public bool Contains(PriorityItem<T> Value)
        {
            ListNode<PriorityItem<T>> Current = this.Head;

            if(Current == null)
                return false;

            do
            {
                Current = Current.Next;
            }while(Current != null && !Current.Value.Equals(Value));

            return true;
        }

        public PriorityItem<T> RemoveStart()
        {
            ListNode<PriorityItem<T>> Curr = this.Head;

            if(Curr == null)
            {
                return null;
            }

            if(Curr.Next == null)
            {
                this.Head = null;
            }
            else
            {
                this.Head = this.Head.Next;
                Curr.Next = null;
            }

            return Curr?.Value;
        }

        public PriorityItem<T> RemoveEnd()
        {
            ListNode<PriorityItem<T>> Curr = this.Head;
            ListNode<PriorityItem<T>> Prev = null;

            if(Curr == null)
            {
                return null;
            }

            do
            {
                Prev = Curr;
                Curr = Curr.Next;
            }while(Curr.Next != null);

            Prev.Next = null;

            return Curr?.Value;
        }

        public void Update(PriorityItem<T> Value, PriorityItem<T> NewValue)
        {
            if(this.Contains(Value))
            {
                ListNode<PriorityItem<T>> Curr = this.Get(Value);

                Curr.Value = NewValue;
            }
        }

       
        /// <summary>
        /// 
        /// </summary>
        public void Print()
        {
            ListNode<PriorityItem<T>> Current = this.Head;
            string Result = "";

            if(Current == null)
                return;
            
            do
            {
                Result += $"{Current.Value} -> "; 
                Current = Current.Next;
            }while(Current != null);

            Console.WriteLine(Result); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public ListNode<PriorityItem<T>> Delete(PriorityItem<T> Value)
        {
            ListNode<PriorityItem<T>> Prev = null;
            ListNode<PriorityItem<T>> Curr = this.Head;

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
                this.size--;
                return this.Head;
            }

            do
            {
                Prev = Curr;
                Curr = Curr.Next;
            }while(Curr.Value != Value);

            Prev.Next = Curr.Next;
            Curr.Next = null;
            this.size--;

            return this.Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListNode<PriorityItem<T>> Peek()
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