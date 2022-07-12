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
    }
}