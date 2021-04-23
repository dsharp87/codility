using System;

namespace permCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new int[] {1,3,2});
        }

        public static int solution(int[] A) 
        {
            //value array
            //iterate through A
            //if val is over max array length, it breaks
            //if val is a dupe it breaks

            int[] vals = new int[A.Length];

            for(int i = 0; i < A.Length; i++)
            {
                if(A[i] > A.Length)
                {
                    return 0;
                }
                else if(vals[A[i] - 1] == 1)
                {
                    return 0;
                }
                else
                {
                    vals[A[i]-1] = 1;
                }
            }
            return 1;
        }
    }
}
