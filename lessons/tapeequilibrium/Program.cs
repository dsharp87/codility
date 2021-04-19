using System;
using System.Linq;

namespace shoopydoopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            solution(new int[] {3,1});
        }

        public static int solution(int[] A) 
        {
            //left sum and right sum
            //setup left and right sum
            int left = A[0];
            //remove first from right
            int right = A.Sum() - left;
            //set intial sum difference
            int mindiff = Math.Abs(left - right);
            
            //start at idx 1, go until length - 1
            for(int i = 1; i < A.Length - 1; i++)
            {
                //remove val from right sum and add it to left
                left += A[i];
                right -= A[i];
                mindiff = Math.Abs(left - right) < mindiff ? Math.Abs(left - right) : mindiff;
            }
            
            
            
            
            return mindiff;
        }
    }
}
