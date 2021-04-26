using System;

namespace countDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(solution(11, 345, 17));
            
        }

        public static int solution(int A, int B, int K) {
            //0 mod X is still 0, sastifies requirement
            if(A == B && A == 0)
            {
                return 1;
            }
            //K could be greater than B
            if(K > B)
            {
                return 0;
            }

            //K could be less than A
            //then we want to find the first T x K that is greater than A <  B
            int firstVal = A % K != 0 ? A/K * K + K : A;

            int range  = B - firstVal;

            if(range < 0)
            {
                return 0;
            }
            else
            {
                //K will fit into the range between T x K times + intial value (0 based in range)
                return 1 + range / K;
            }
        }
    }
}
