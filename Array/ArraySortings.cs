namespace DatastructureAlgorithms.ArraySorting
{
    public static class ArraySortings
    {
        public static int[] BubbleSort(int[] unsortedArray)
        {
            for(var i = 0; i < unsortedArray.Length - 1; i++)
            {
                for(var j = 1; j < unsortedArray.Length - 1; j++)
                {
                    if(unsortedArray[j] > unsortedArray[j+1])
                    {
                        int temp = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j+1];
                        unsortedArray[j+1] = temp;
                    }
                }
            }

            return unsortedArray;
        }

        public static int[] SelectionSort(int[] unsortedArray)
        {
            for(var i = 0; i <= unsortedArray.Length - 1; i++)
            {
                var min = i;
                for(var j = i + 1; j < unsortedArray.Length; j++)
                {
                    if(unsortedArray[j] < unsortedArray[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var temp = unsortedArray[min];
                    unsortedArray[min] = unsortedArray[i];
                    unsortedArray[i] = temp;
                }
            }

            return unsortedArray;
        }
    }

}