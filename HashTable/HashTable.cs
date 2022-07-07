using System;
using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.HashTables
{
    public class HashTable<T> where T : class
    {
        private LinkedLists<T>[] _hashtable; 
        public HashTable()
        {
            _hashtable = new LinkedLists<T>[1000];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void Insert(int Key, T Value)
        {
            int hashKey = this.Hash(Key);
            Console.WriteLine(hashKey);

            if(_hashtable[hashKey].Find(Value))
            {
                _hashtable[hashKey].InsertAtEnd(Value);
            }
            else
            {
                _hashtable[hashKey] = new LinkedLists<T>();
                _hashtable[hashKey].InsertAtEnd(Value);
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public ListNode<T> GetValue(int Key, T Value)
        {
            int hashKey = this.Hash(Key);
            
            return _hashtable[hashKey].Search(Value);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void Delete(int Key, T Value)
        {
            int hashKey = this.Hash(Key);
            _hashtable[hashKey].DeleteNode(Value);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        private int Hash(int Key)
        {
            int length = Key.ToString().Length;

            return Convert.ToInt32(length * (Key * 25 % 509));
        }

        // /// <summary>
        // /// 
        // /// </summary>
        // /// <returns></returns>
        // public override string ToString()
        // {
        //     string result = "";

        //     foreach(var item in _hashtable)
        //     {
        //         if(item.Value.Head != null)
        //         {
        //             item.Value.PrintList();

        //         }
        //     }
        //     return result; 
        // }
    }
}