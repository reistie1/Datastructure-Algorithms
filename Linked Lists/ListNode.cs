namespace Datastructures_LinkedList
{
    public class ListNode
    {
        public int _val;
        public ListNode _next;
        public ListNode _prev;
        public ListNode(int val = 0, ListNode next = null, ListNode prev = null)
        {
            this._val = val;
            this._next = next;
            this._prev = prev;
        }
    }
}