using Datastructures_LinkedList;

namespace DatastructureAlgorithms.Linked_Lists
{
    public class LinkedLists
    {
        private ListNode _head;
        public LinkedLists()
        {
            this._head = null;
        }

        public LinkedLists(ListNode head)
        {
            this._head = head;
        }

        public ListNode CreateList(int[] input_list)
        {
            ListNode temp = this._head;
            int index = 0;

            do
            {
                index++;
                temp = temp._next;
            }while(index <= input_list.Length - 1);

            return this._head;
        }

        public ListNode Add(ListNode newNode)
        {
            newNode._next = this._head;
            this._head = newNode;

            return this._head;
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
                if(temp2._val == val)
                {
                    temp2._next = null;
                    temp1._next = temp2._next;
                }

                temp2 = temp2._next;
                temp1 = temp1._next;
            }while(temp2._next != null);

            return this._head;
        }
    }
}