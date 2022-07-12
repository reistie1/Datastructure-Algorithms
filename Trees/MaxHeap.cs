using System;
using DatastructureAlgorithms.Trees;

namespace DatastructureAlgorithms.MaxHeap
{
    public class MaxHeaps
    {
        private int[] Heap;
        private int Size;
        private int MaxSize;

        public MaxHeaps(int maxSize)
        {
            this.MaxSize = maxSize;
            this.Size = 0;
            this.Heap = new int[maxSize];
        }

        private int Parent(int position)
        {
            return (position - 1) / 2;
        }

        private int LeftChild(int position)
        {
            return (2 * position) + 1;
        }

        private int RightChild(int position)
        {
            return (2 * position) + 2;
        }

        private bool IsLeaf(int position)
        {
            return (position > (this.Size / 2) && position <= this.Size) ? true : false;
        }

        private void Swap(int FirstPosition, int SecondPosition)
        {
            int Temp = this.Heap[FirstPosition];
            this.Heap[FirstPosition] = this.Heap[SecondPosition];
            this.Heap[SecondPosition] = Temp;

        }

        private void MaxHeapify(int Position)
        {
            if (this.IsLeaf(Position))
                return;
    
            if (this.Heap[Position] < this.Heap[this.LeftChild(Position)] || this.Heap[Position] < this.Heap[this.RightChild(Position)]) {
    
                if (this.Heap[this.LeftChild(Position)] > this.Heap[this.RightChild(Position)]) {
                    this.Swap(Position, this.LeftChild(Position));
                    this.MaxHeapify(this.LeftChild(Position));
                }
                else {
                    this.Swap(Position, this.RightChild(Position));
                    this.MaxHeapify(this.RightChild(Position));
                }
            }
        }

        public void Insert(int Element)
        {
            this.Heap[this.Size] = Element;
            int Current = this.Size;

            while (Heap[Current] > Heap[this.Parent(Current)]) {
                this.Swap(Current, this.Parent(Current));
                Current = this.Parent(Current);
            }

            this.Size++;
        }

        public int ExtractMax()
        {
            int Max = this.Heap[0];
            this.Heap[0] = Heap[--this.Size];
            this.MaxHeapify(0);

            return Max;
        }

        public void Print()
        {
            for(int i = 0; i < this.Size / 2; i++)
            {
                Console.WriteLine("Parent Node : " + Heap[i] );
                
                if(this.LeftChild(i) < this.Size) //if the child is out of the bound of the array
                    Console.WriteLine( " Left Child Node: " + Heap[this.LeftChild(i)]);
                
                if(this.RightChild(i) < this.Size) //if the right child index must not be out of the index of the array
                    Console.WriteLine(" Right Child Node: "+ Heap[this.RightChild(i)]);
                
                    Console.WriteLine(); //for new line 
            }
        }
    }
}