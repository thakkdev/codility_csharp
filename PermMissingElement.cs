/* given array A such that:

  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5
the function should return 4, as it is the missing element.

N is an integer within the range [0..100,000];
the elements of A are all distinct;
each element of array A is an integer within the range [1..(N + 1)].
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilitycsharp
{
    class PermMissingElement
    {

        public int solution(int[] A)
        {
            //sort the array
            Array.Sort(A);
            int startnum = 1;
            int numpos = 0;
            bool firstround = true;
            foreach(var item in A)
            {
                //first value should be 1. Else return 1 as missing value
                if(firstround)
                {
                    
                    if(startnum != item)
                    {
                        return 1;
                    }
                    numpos = item;
                    firstround = false;
                }
                else
                {
                    //If next item is not increment of 1 or same as before then 
                    // that is the missing value
                    if(numpos == item || numpos+1 == item)
                    {
                        numpos = item;
                    }
                    else
                    {
                        return numpos + 1;
                    }
                }
            }

            //return next value if for loop did not identify any missing
            return numpos+1;
        }
    }
}
