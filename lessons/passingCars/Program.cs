using System;
using System.Collections.Generic;

namespace passingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(solution(new int[] {0,1,0,1,1}));
        }

        public static int solution(int[] A)
        {
            //need a count of how many of eastbund 
            //when a west bound is found, add how many east we've seen already

            int eastCount = 0;
            long result = 0;

            for(int i = 0; i<A.Length; i++)
            {
                if(A[i] == 0)
                {
                    eastCount++;
                }
                else
                {
                    result += eastCount;
                }
            }

            return result <= 1000000000 ? (int)result : -1;
        }
    }
}
