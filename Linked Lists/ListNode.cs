namespace Datastructures_LinkedList
{
    public class ListNode<T> where T : class
    {
        public T Value;
        public ListNode<T> Next;
        public ListNode<T> Prev;
        public ListNode(T Value)
        {
            this.Value = Value;
            this.Next = null;
            this.Prev = null;
        }
    }
}