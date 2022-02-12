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

        public void Insert(int key, T value)
        {
            double hashKey = this.Hash(key);
            Console.WriteLine(hashKey);

            if(_hashtable.ContainsKey(hashKey))
            {
                _hashtable[hashKey].InsertAtEnd(value);
            }
            else
            {
                _hashtable[hashKey] = new LinkedLists<T>();
                _hashtable[hashKey].InsertAtStart(value);
            } 
        }

        public void Delete(int key, T value)
        {
            double hashKey = this.Hash(key);
            _hashtable[hashKey].DeleteNode(value);

        }

        private double Hash(int key)
        {
            int length = key.ToString().Length;

            return length * (key * 25 % 509);
        }

        public override string ToString()
        {
            string result = "";

            foreach(var item in _hashtable)
            {
                if(item.Value.head != null)
                {
                    item.Value.printList();

                }
            }
            return result; 
        }
    }
}