using System;

namespace DatastructureAlgorithms.ArraySearch
{
    public static class ArraySearchs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int LinearSearch(int[] arr, int value)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                if(arr[i] == value)
                {
                    return arr[i];
                }
            }

            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int value)
        {
            int low = 1;
            int high = arr.Length;
            int mid = 0;
            

            do
            {
                mid = (low + (low + high) / 2);

                if(mid > arr.Length)
                {
                    break;
                }

                if(value < arr[mid])
                {
                    high = mid - 1;
                }
                if(value > arr[mid])
                {
                    low = mid + 1;
                }
                if(value == arr[mid])
                {
                    return arr[mid];
                }
            }while(low < high);

            return -1;

        }
    }
}