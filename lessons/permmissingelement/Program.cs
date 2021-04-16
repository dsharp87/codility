using System;

namespace permmissingelement
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(solution(new int[]{4,1,2}));
            solution(new int[] {1,2});
        }

        public static int solution(int[] A) {
            
            //array can be empty
            if(A.Length == 0)
            {
                return 1;
            }
            //array is not sorted
            //must be efficient
            //could make an array the same lenght  + 1
            //then add all values
            //then find index of the 0

            int[] copy = new int[A.Length + 1];
            for(int i = 0; i < A.Length; i++)
            {
                copy[A[i] -1 ] = A[i];
            }

            return Array.IndexOf(copy, 0) + 1;
        }


    }
}
