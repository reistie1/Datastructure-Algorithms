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
    }
}