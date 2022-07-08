using System;
using System.Collections.Generic;
using DatastructureAlgorithms.Linked_List;
using Datastructures_LinkedList;

namespace DatastructureAlgorithms.HashTables
{
    public class HashTable<T> where T: class
    {
        private LinkedLists<T>[] _hashtable; 
        public HashTable(int Size)
        {
            _hashtable = new LinkedLists<T>[Size];
        }   

        public void Insert(T Key)
        {
            int HashKey = this.GenerateHashKey(this.GetTypeValue(Key));
            Console.WriteLine(HashKey);

            if(_hashtable[HashKey] == null)
            {
                LinkedLists<T> NewList = new LinkedLists<T>();
                NewList.InsertAtEnd(Key);

                _hashtable[HashKey] = NewList;
            }
            else
            {
                _hashtable[HashKey].InsertAtEnd(Key);
            }
        }  

        public bool ContainsValue(T Key)
        {
            int HashKey = this.GenerateHashKey(this.GetTypeValue(Key));

            if(_hashtable[HashKey] != null)
            {
                var Result = _hashtable[HashKey].Search(Key)?.Value;
                if(Result != null)
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(T Key)
        {
            int HashKey = this.GenerateHashKey(this.GetTypeValue(Key));

            if(_hashtable[HashKey] != null)
            {
                _hashtable[HashKey].DeleteNode(Key);
            }
        }

        public T GetValue(T Key)
        {
            int HashKey = this.GenerateHashKey(this.GetTypeValue(Key));

            if(_hashtable[HashKey] != null)
            {
                return _hashtable[HashKey].Search(Key).Value;
            }

            return null;
        }

        public int Size()
        {
            int Size = 0;

            for(var i = 0; i < _hashtable.Length; i++)
            {
                if(_hashtable[i] != null)
                {
                    Size++;
                }
            }

            return Size;
        } 

        public void Clear()
        {
            for(var i = 0; i < _hashtable.Length; i++)
            {
                _hashtable[i] = null;
            }
        }

        public bool Contains(T Key)
        {
            int HashKey = this.GenerateHashKey(this.GetTypeValue(Key));

            if(_hashtable[HashKey] != null)
            {
                return _hashtable[HashKey].Find(Key);
            }
            return false;
        }

        public bool ContainsKey(T Key)
        {
            int HashKey = this.GenerateHashKey(this.GetTypeValue(Key));

            if(_hashtable[HashKey] != null)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            for(var i = 0; i < _hashtable.Length; i++)
            {
                if(_hashtable[i] != null)
                {
                    return false;
                }
            }

            return true;
        }

        private int GetTypeValue(T Key)
        {
            int KeyNumber = 0;

            foreach(var item in Key.ToString())
            {
                KeyNumber += (int)item;
            }

            return KeyNumber;
        }

        private int GenerateHashKey(int Key)
        {
            return (Key * 52) % 509;
        } 

        public void PrintEachHashBucket()
        {
            for(int i = 0; i < _hashtable.Length; i++)
            {
                if(_hashtable[i] != null)
                {
                    _hashtable[i].PrintList();
                }
            }
        }
    }
}