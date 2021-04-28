using System;

namespace minAvgTwoSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(solution(new int[] {4, 2, 2, 5, 1, 5, 8}));
        }

        public static int solution(int[] A) 
        {
            if(A.Length == 2)
            {
                return 0;
            }
            //could get average of whole array
            //then could check average of left / right
            //recurisvely do this until you find the smallest?, but no garuntee it would be an exact slice

            //realization
            //all sums could be assmebled with a combination of 2 slices or 2 and 3 slices, so just find the minimum of that

            //intialize first cases
            int minTwoSlice = A[0] + A[1];
            int minTwoIdx = 0;

            int minThreeSlice = int.MaxValue;
            int minThreeIdx = 0;

            //iterate and find smallest of the 2 and 3 slices
            for(int i = 2; i< A.Length; i++)
            {
                int twoSlice = A[i - 1] + A[i];
                if(twoSlice < minTwoSlice)
                {
                    minTwoSlice = twoSlice;
                    minTwoIdx = i-1;
                }

                int threeSlice = twoSlice + A[i-2];
                if(threeSlice < minThreeSlice)
                {
                    minThreeSlice = threeSlice;
                    minThreeIdx = i - 2;
                }


            }

            double averageTwo = (double)minTwoSlice/2;
            double averageThree = (double)minThreeSlice/3;

            //same average, return earlier idx
            if(averageTwo == averageThree)
            {
                return Math.Min(minTwoIdx, minThreeIdx);
            }
            //otherwise return the smaller of the two averages
            else
            {
                return averageTwo < averageThree ? minTwoIdx : minThreeIdx;
            }
        }
    }
}
