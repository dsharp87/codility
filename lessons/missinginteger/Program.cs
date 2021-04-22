using System;

namespace missinginteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            solution(new int[] {-1000000, 1000000});
        }

        public static int solution(int[] A)
        {
            int[] vals =  new int[100002];
            vals[0] = 1;
            for(int i =0; i < A.Length; i++)
            {
                int val = A[i];
                if(A[i] > 0 && A[i] < 100002)
                {
                    vals[A[i]] = 1;
                }
            }
            return Array.IndexOf(vals, 0);
        }
    }
}
