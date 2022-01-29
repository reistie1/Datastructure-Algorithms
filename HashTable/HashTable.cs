using System;
using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;

namespace DatastructureAlgorithms.HashTables
{
    public class HashTable
    {
        private Dictionary<string, LinkedLists<string>> _hashtable; 
        public HashTable()
        {
            _hashtable = new Dictionary<string, LinkedLists<string>>();
        }

        public void Insert(string key, string value)
        {
            var hashKey = this.Hash(value).ToString();
            _hashtable.Add(hashKey, new LinkedLists<string>());
        }

        private int Hash(string key)
        {
            return (key.Length % 509);
        }

        public override string ToString()
        {
            
            string result = "";

            foreach(var item in _hashtable)
            {
                Console.WriteLine(item.Key);
            }

            return result; 
        }
    }
}