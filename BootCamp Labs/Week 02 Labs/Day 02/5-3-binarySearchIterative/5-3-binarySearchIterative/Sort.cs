using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_binarySearchIterative
{
    internal class Sort: Search
    {
        public int[] sortArray(int[] arr)
        {
            int temp = 0;
            for(int j=0; j<arr.Length; j++)
            {
                for(int i=0; i<arr.Length-1; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public void printArray(int[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
