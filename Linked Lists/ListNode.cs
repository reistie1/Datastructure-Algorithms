namespace Datastructures_LinkedList
{
    public class ListNode<T> where T : class
    {
        public T value;
        public ListNode<T> next;
        public ListNode<T> prev;
        public ListNode(T value)
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }
    }
}