/*
 given N = 1041 the function should return 5, because N has binary representation 10000010001 
 and so its longest binary gap is of length 5.

*/
using System;

namespace codilitycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1041));
        }

        static int solution(int N)
        {
			//convert to binary
            string binary = Convert.ToString(N, 2);
			
            bool start1 = false;
            int maxcount = 0;
            int sumcount = 0;

            foreach (var item in binary)
            {
                if(item == '1')
                {
                    if (!start1)
                    {
                        start1 = true;
                    }
                    else
                    {
                        if (maxcount < sumcount)
                        {
                            maxcount = sumcount;
                        }
                        
                        //reset sumcount to 0 when item value is '1'
						sumcount = 0;
                    }
                }
                else
                {
                    if(start1)
                    {
                        sumcount = sumcount + 1;
                    }
                }
 
            }
            return maxcount;
        }
    }
}
