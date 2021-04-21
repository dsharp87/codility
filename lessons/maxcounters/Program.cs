using System;

namespace maxcounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            int[] nums = new int[] {3,4,4,6,1,4,4};
            solution(count, nums);
        }

        public static int[] solution(int N, int[] A) 
        {
            int max = 0;
            int maxAtmaxHit = 0;
            int[] result = new int[N];
            bool maxflag = false;
            for(int i = 0; i < A.Length; i++)
            {
                int idx = A[i] - 1;
                if(idx != N)
                {
                    if(maxflag && result[idx] <= maxAtmaxHit)
                    {
                        result[idx] = maxAtmaxHit + 1;
                    }
                    else
                    {
                        result[idx]++;
                    }
                    max = result[idx] > max ? result[idx] : max; 
                }
                else
                {
                    maxflag  = true;
                    maxAtmaxHit = max;
                }
            }
            for(int i = 0; i < result.Length; i++)
            {
                if(result[i] < maxAtmaxHit)
                {
                    result[i] = maxAtmaxHit;
                }
            }
            return result;
        }

        
    }
}
