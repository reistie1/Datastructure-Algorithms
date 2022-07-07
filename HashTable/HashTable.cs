using System;
using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;

namespace DatastructureAlgorithms.HashTables
{
    public class HashTable<T> where T : class
    {
        private Dictionary<double, LinkedLists<T>> _hashtable; 
        public HashTable()
        {
            _hashtable = new Dictionary<double, LinkedLists<T>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void Insert(int Key, T Value)
        {
            double hashKey = this.Hash(Key);
            Console.WriteLine(hashKey);

            if(_hashtable.ContainsKey(hashKey))
            {
                _hashtable[hashKey].InsertAtEnd(Value);
            }
            else
            {
                _hashtable[hashKey] = new LinkedLists<T>();
                _hashtable[hashKey].InsertAtStart(Value);
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void Delete(int Key, T Value)
        {
            double hashKey = this.Hash(Key);
            _hashtable[hashKey].DeleteNode(Value);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        private double Hash(int Key)
        {
            int length = Key.ToString().Length;

            return length * (Key * 25 % 509);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";

            foreach(var item in _hashtable)
            {
                if(item.Value.Head != null)
                {
                    item.Value.PrintList();

                }
            }
            return result; 
        }
    }
}