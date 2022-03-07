/*
given

    A = [3, 8, 9, 7, 6]
    K = 3
the function should return [9, 7, 6, 3, 8]. Three rotations were made:
*/
namespace CSharp
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            
            int[] startarr = new int[A.Length];;

            if(A.Length == 1 || A.Length < 1)
            {
                return A;
            }

            //If K > A.Length then subtract till K is less
            while(K > A.Length == true)
            {
               if(K > A.Length)
                {
                    K = K- A.Length;
                }
            }

            if(K == A.Length)
            {
                return A;
            }

            if(K < 1 )
            {
                return A;
            }


            //find position from right to A.Length that will be moved to start from position 0 
            int liftrightside = A.Length - K;

            //find count from left that will be moved to start from K 
            // K will be less than A.Length
            int countleftside = A.Length - K-1;

            int j=0;
            for (int i=liftrightside; i<A.Length;i++)
            {
                startarr[j] = A[i];
                j=j+1;
            }

            int n = K;
            for (int m=0; m<=countleftside; m++)
           {
                startarr[n] = A[m];
                n= n+ 1;
           }

            //Console.WriteLine(startarr.ToList());
            //Console.WriteLine(String.Join(",", startarr));
            return startarr;
        }
    }
}
