/*
 * given an array A consisting of N integers
 * 
 * For example
 * A[0] = 9  A[1] = 3  A[2] = 9
 * A[3] = 3  A[4] = 9  A[5] = 7
 * A[6] = 9
 * function should return 7
 * 
 * N is an odd integer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilitycsharp
{
    class OddOccurrence
    {
        public int solution(int[] A)
        {
            //HashSet store unique values
            HashSet<int> hs = new HashSet<int>();

           foreach(var item in A)
            {
                if(hs.Contains(item))
                {
                    hs.Remove(item);
                }
                else
                {
                    hs.Add(item);
                }
            }

           //only the odd value that does not match will remain
            return hs.First();
        }

    }
}
