using System;

namespace genomicRangeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(solution("CAGCCTA", new int[] {2,5,0}, new int[] {4,5,6}));
        }

        public static int[] solution(string S, int[] P, int[] Q)
        {
            //iterate through p and q, each time those are the bounds
            //needs to be efficient, meaning we can't look through the entire range each time

            //edge cases
            //if K is the same, then just add the val,
            
            //convert string to numbers
            int[] vals = new int[S.Length];
            for(int i = 0; i < S.Length; i++)
            {
                vals[i] = letterToVal(S[i]);
            }

            //result storage array
            int[] result = new int[P.Length];

            int[] lastbounds = new int[] {P[0], Q[0]};
            int lastmin = 5;
            
            for( int i = lastbounds[0]; i<=lastbounds[1]; i++)
            {
                lastmin = vals[i] < lastmin ? vals[i] : lastmin;
                if(lastmin == 1)
                {
                    break;
                }
            }
            result[0] = lastmin;

            for(int k = 1; k < P.Length; k++)
            {
                if(P[k] == Q[k])
                {
                    result[k] = vals[P[k]];
                }
                else if(P[k] <= lastbounds[0] && Q[k] >= lastbounds[1]  && lastmin == 1)
                {
                    result[k] = lastmin;
                    lastbounds[0] = P[k];
                    lastbounds[1] = Q[k];
                }
                else
                {
                    int currmin = 5;
                    for(int i = P[k]; i <= Q[k]; i++)
                    {
                        currmin = vals[i] < currmin ? vals[i] : currmin;
                        if(currmin == 1)
                        {
                            break;
                        }
                    }
                    lastbounds[0] = P[k];
                    lastbounds[1] = Q[k];
                    lastmin = currmin;
                    result[k] = lastmin;
                }
                
            }
            return result;

        }

        public static int letterToVal(char c)
        {
            char[] nucs = new char[]{'A','C','G','T'};
            return Array.IndexOf(nucs, c) + 1;
        }
    }
}
