using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_linearSearch
{
    internal class Search
    {
        public int linearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
