using System;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(new int[] {1,2,3});
        }

        public static int solution(int[] A) 
        {
          
          //make an array of lenght 100000
          //set all values to 0 by default
          int[] vals = new int[100001];
          

          //iterate through entire A, set value array of that value to 1 ONLY IF val is > 0
          for(int i=0; i < A.Length; i++)
          {
              if(A[i] > 0)
              {
                  vals[A[i]] = 1;
              }
          }
        
          //once complete, iterate through value array, return first value still set to 0
          for(int i=1; i<vals.Length; i++)
          {
              if(vals[i] == 0)
              {
                  return i;
              }
          }

        
            return 100001;

        }
    }
}
