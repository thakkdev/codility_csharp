/*
 * that, given an array A consisting of N i
 * ntegers, returns index of any element of 
 * array A in which the dominator of A occurs. 
 * The function should return −1 if array A 
 * does not have a dominator.

For example, given array A such that

 A[0] = 3    A[1] = 4    A[2] =  3
 A[3] = 2    A[4] = 3    A[5] = -1
 A[6] = 3    A[7] = 3
 
 * 
 * The dominator of A is 3 
 *  because it occurs in 5 out of 8 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilitycsharp
{
    class Dominator
    {
        public int solution(int[] A)
        {
            //Increment recurring values in aDict
            Dictionary<int, int> aDict = new Dictionary<int, int>();
            
            //track index position of value
            Dictionary<int, int> aDictInd = new Dictionary<int, int>();

            int alen = A.Length;
            int pos = 0; 

            foreach(var item in A)
            {
                if(aDict.ContainsKey(item))
                {
                    aDict[item] = aDict[item] + 1;
                }
                else
                {
                    aDict.Add(item, 1);
                }
                aDictInd[item] = pos;
                pos = pos + 1;
            }

            if(alen > 0)
            {
               foreach(var key in aDict.Keys)
               {
                    // check if recurring value occurs >
                    // 50% of total length
                    if(aDict[key] > alen / 2 )
                    {
                        //return index position of value
                        return aDictInd[key];
                    }
               }
            }

            return -1;
        }
    }
}
