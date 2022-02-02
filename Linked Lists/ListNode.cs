namespace Datastructures_LinkedList
{
    public class ListNode
    {
        public int value;
        public string otherValue;
        public ListNode next;
        public ListNode prev;
        public ListNode(int value)
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }

        public ListNode(string value)
        {
            this.otherValue = value;
            this.next = null;
            this.prev = null;
        }
    }
}