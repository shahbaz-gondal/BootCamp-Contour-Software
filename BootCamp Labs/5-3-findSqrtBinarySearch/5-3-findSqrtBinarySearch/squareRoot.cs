using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_findSqrtBinarySearch
{
    internal class squareRoot
    {
        public int findSqrt(int n, int l, int r, int mid)
        {
            while(mid*mid != n && l!=r-1)
            {
                if(mid*mid > n)
                {
                    r = mid;
                    mid = (l+r)/2;
                }
                else if(mid*mid < n)
                {
                    l = mid;
                    mid = (l + r) / 2;
                }
            }
            return mid;
        }
    }
}
