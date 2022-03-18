/*
 * given array A consisting of six elements such that:

  A[0] = 23171
  A[1] = 21011
  A[2] = 21123
  A[3] = 21366
  A[4] = 21013
  A[5] = 21367
the function should return 356

returns the maximum possible profit from one transaction during this period. 
The function should return 0 if it was impossible to gain any profit.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FurthestRepeatingDiagram --- used a real test

namespace codilitycsharp
{
    class MaxProfit
    {

        public int solution(int[] A)
        {

            //reverse the Array. eg Day pos 1,2,3,4
            //with values becomes Day pos 4,3,2,1
            var arrRev = A.Reverse();

            int[] newarr = arrRev.ToArray();

            int maxval = 0;
            int itempos = 0;
            bool firstitem = true;
            bool skiploop = false;
            HashSet<int> hs = new HashSet<int>();
            HashSet<int> hslow = new HashSet<int>();

            foreach (var item in newarr)
            {

                //optimize
                // if item is less then prev items then move to next item (skiploop = true)
                if (firstitem)
                {
                    firstitem = false;
                }
                else
                {
                    //initial
                    skiploop = false;

                    //lowskip condition
                    if (hslow.Contains(item))
                    {
                        skiploop = true;

                    }
                    else
                    {
                        //optimize foreach loop
                        foreach (var hsitem in hs)
                        {
                            if (hsitem >= item)
                            {
                                skiploop = true;
                                break;
                            }
                        }
                    }
                }

                //to check profit - subtract item value (eg from Day 4) with
                //Day 3, Day 2, Day 1, Day 0
                if (!skiploop)
                {
                    for (int i = itempos + 1; i < A.Length; i++)
                    {
                        int nextval = newarr[i];
                        if (item > nextval)
                        {
                            //nextval value is lower then prv day
                            // skip the next time around by checking  "lowskip condition"
                            hslow.Add(nextval);
                            int profit = item - nextval;
                            if (maxval < profit)
                            {
                                maxval = profit;
                                //add item to hashset - only unique values in a hs
                                hs.Add(item);
                            }
                        }

                    }
                }
            
                itempos = itempos + 1;
            }

            if(maxval < 0)
            {
                maxval = 0;
            }
            return maxval;
        }
    }
}
