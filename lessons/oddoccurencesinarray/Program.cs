using System;

namespace oddoccurencesinarray
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new int[] {9, 3, 9, 3, 9, 7, 9});
        }

        public static int solution(int[] A)
        {
            int[] vals = new int[1000000];
            for(int i=0; i<A.Length; i++)
            {
                if(vals[A[i]-1] == 0)
                {
                    vals[A[i]-1] = 1;
                }
                else
                {
                    vals[A[i]-1] = 0;
                }
            }
            int idx = Array.IndexOf(vals, 1);
            return vals[idx] + 1;
        }
    }
}
