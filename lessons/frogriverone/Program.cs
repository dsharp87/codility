using System;

namespace frogriverone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //this times out on large permutation and large range tests
        public static int solution_old(int X, int[] A)
        {
            int[] river = new int[X];

            for(int i = 0; i<A.Length; i++)
            {
                river[A[i] - 1] = 1;
                if(Array.IndexOf(river, 0) == -1)
                {
                    return i;
                }
            }
            return -1;
        }

        //more efficient, don't search through river array after each leaf
        public static int solution(int X, int[] A)
        {
            int[] river = new int[X];
            int emptyCount = X;

            for(int i = 0; i<A.Length; i++)
            {
                if(river[A[i] - 1] == 0)
                {
                    river[A[i] - 1] = 1;
                    emptyCount--;
                }
                
                if(emptyCount == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
