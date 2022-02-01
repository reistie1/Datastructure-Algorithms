using System;
using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;

namespace DatastructureAlgorithms.HashTables
{
    public class HashTable
    {
        private Dictionary<double, LinkedLists<string>> _hashtable; 
        public HashTable()
        {
            _hashtable = new Dictionary<double, LinkedLists<string>>();
        }

        public void Insert(int key, string value)
        {
            double hashKey = this.Hash(key);
            Console.WriteLine(hashKey);

            if(_hashtable.ContainsKey(hashKey))
            {
                _hashtable[hashKey].AddToEnd(value);
            }
            else
            {
                _hashtable[hashKey] = new LinkedLists<string>();
                _hashtable[hashKey].AddToStart(value);
            } 
        }

        public void Delete(int key, string value)
        {
            double hashKey = this.Hash(key);
            _hashtable[hashKey].Delete(value);

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