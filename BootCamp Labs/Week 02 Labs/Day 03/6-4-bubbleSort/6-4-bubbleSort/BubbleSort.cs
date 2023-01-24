using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_bubbleSort
{
    internal class BubbleSort
    {
        public int[] bubbleSort(int[] arr)
        {
            int temp = 0;
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j<arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }
        public void printArray(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
