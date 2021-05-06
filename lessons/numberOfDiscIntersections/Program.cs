using System;

namespace numberOfDiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new int[]{1,5,2,1,4,0});
        }

        //brute force solution
        public static int solutionBrute(int[] A) 
        {
            //return -1 if count exceeds 10,000,000
            //discs intersect if they share a point on the x axis

            //go through each vertex A[i]
            //interate to every virtex after i, A[j]
            //if i + A[i] >= j - A[j], they intersect

            int count = 0;

            for(int i = 0; i < A.Length -1; i++)
            {

                for(int j = i + 1; j < A.Length; j++)
                {
                    //if radius takes it past int bounds
                    long overflow = (long)(i + A[i]);
                    if(overflow >= j - A[j])
                    {
                        count++;
                    }
                }
            }


            return count > 10000000 ? -1 : count;
        }
        //elegant solution using sorts
        public static int solution(int[] A) 
        {
            //index of starting and ending indexes
            long[] start = new long[A.Length];
            long[] end = new long[A.Length];

            //store starting and ending indexes 
            for(int i = 0; i < A.Length; i++)
            {
                start[i] = i - A[i];
                end[i] = i + A[i];
            }
            //sort the arrays
            //note start[i] , end[i] no longer represent index of Disc i
            Array.Sort(start);
            Array.Sort(end);

            //number of currently open disc
            int open = 0;
            //number of intersections detected
            int result = 0;

            //pointer for closing array
            int endIdx = 0;

            //looking for disc openings that overlap
            //for each close, we know that one of the discs has closed, but the rest still are open
            //this is idependent of how the open/closes actually line up with a specific disc
            for(int i = 0; i < start.Length; i++)
            {
                //1 or more discs are going to close before more discs are open
                //move end pointer up each time
                while(start[i] > end[endIdx])
                {
                    open--;
                    endIdx++;
                }
                //all currently open discs intersect
                result += open;
                //increase open count after
                open++;
            }

            return result > 10000000 ? -1 : result;
        }
    }
}
