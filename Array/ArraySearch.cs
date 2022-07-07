using System;

namespace DatastructureAlgorithms.ArraySearch
{
    public static class ArraySearchs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Arr"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static int LinearSearch(int[] Arr, int Value)
        {
            for(var i = 0; i < Arr.Length; i++)
            {
                if(Arr[i] == Value)
                {
                    return Arr[i];
                }
            }

            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Arr"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] Arr, int Value)
        {
            int Low = 1;
            int High = Arr.Length;
            int Mid = 0;
            

            do
            {
                Mid = (Low + (Low + High) / 2);

                if(Mid > Arr.Length)
                {
                    break;
                }

                if(Value < Arr[Mid])
                {
                    High = Mid - 1;
                }
                else if(Value > Arr[Mid])
                {
                    Low = Mid + 1;
                }
                else
                {
                    return Arr[Mid];
                }
            }while(Low < High);

            return -1;

        }
    }
}