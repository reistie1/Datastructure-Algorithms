using System;

namespace DatastructureAlgorithms.ArraySorting
{
    public static class ArraySortings
    {
        public static int[] BubbleSort(int[] UnsortedArray)
        {
            for(var i = 0; i < UnsortedArray.Length - 1; i++)
            {
                for(var j = 1; j < UnsortedArray.Length - 1; j++)
                {
                    if(UnsortedArray[j] > UnsortedArray[j+1])
                    {
                        int Temp = UnsortedArray[j];
                        UnsortedArray[j] = UnsortedArray[j+1];
                        UnsortedArray[j+1] = Temp;
                    }
                }
            }

            return UnsortedArray;
        }

        public static int[] SelectionSort(int[] UnsortedArray)
        {
            for(var i = 0; i <= UnsortedArray.Length - 1; i++)
            {
                var Min = i;
                for(var j = i + 1; j < UnsortedArray.Length; j++)
                {
                    if(UnsortedArray[j] < UnsortedArray[Min])
                    {
                        Min = j;
                    }
                }

                if (Min != i)
                {
                    var Temp = UnsortedArray[Min];
                    UnsortedArray[Min] = UnsortedArray[i];
                    UnsortedArray[i] = Temp;
                }
            }

            return UnsortedArray;
        }

        public static int[] InsertionSort(int[] arr, int n)
        {
            int i, key, j;
            for(i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            return arr;
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            int[] Left = new int[n1];
            int[] Right = new int[n2];

            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
                Left[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                Right[j] = arr[m + 1 + j];

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray
            j = 0; // Initial index of second subarray
            k = l; // Initial index of merged subarray
            while (i < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    arr[k] = Left[i];
                    i++;
                }
                else
                {
                    arr[k] = Right[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there 
            are any */
            while (i < n1)
            {
                arr[k] = Left[i];
                i++;
                k++;
            }

            /* Copy the remaining elements of R[], if there 
            are any */
            while (j < n2)
            {
                arr[k] = Right[j];
                j++;
                k++;
            }
        }


        public static int[] MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }

            return arr;
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);	   

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);

            return (i + 1);
        }

        public static void Swap(int[] arr, int i1, int i2)
        {
            int t = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = t;
        }

        public static int[] QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                PrintArray(arr);


                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }

            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine();
        }

        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;
    
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);
    
            for (int i = n - 1; i > 0; i--) {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
    
                Heapify(arr, i, 0);
            }
        }

        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; 
            int l = 2 * i + 1;
            int r = 2 * i + 2; 
    
            if (l < n && arr[l] > arr[largest])
                largest = l;
    
            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;
    
            // If largest is not root
            if (largest != i) {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
    
                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }
    }
}