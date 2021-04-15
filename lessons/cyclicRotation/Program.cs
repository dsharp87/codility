using System;

namespace cyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new int[] {3,8,9,6}, 3);
        }

        public static int[] solution(int[] A, int K) 
        {
            //use mod to rotate only the smallest amount
            
            //make a new array
            //to do in place will needs a storage array, which could result in saving up ot half the array an additional time
            //if in place, we want to do a left or right shift to minimize sizeof storage array and double visiting elements
            if(K == 0 || A.Length==0)
            {
                return A;
            }

            int shift = K % A.Length;
            if(shift == 0)
            {
                return A;
            }

            int[] result = new int[A.Length];

            for(int i= A.Length-1; i >= shift; i--)
            {
                result[i] = A[i-shift];
            }

            for(int i = 0; i < shift; i++)
            {
                result[i] = A[A.Length-shift+i];
            }

            return result;
        }
    }
}
