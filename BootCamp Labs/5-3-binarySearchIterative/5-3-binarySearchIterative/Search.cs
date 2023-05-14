using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_binarySearchIterative
{
    internal class Search
    {
        public int binarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            int mid = (r+l)/2;
            while (x != arr[mid])
            {
                if(x < arr[mid] & l!=r)
                {
                    r= mid;
                    mid = (r + l) / 2;
                }
                if (x > arr[mid] & l!=r)
                {
                    l = mid + 1;
                    mid =(r + l) / 2;
                }
                else if(l==r)
                {
                    return -1;
                }
            }
            return mid;
        }
    }
}
