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
    }

}