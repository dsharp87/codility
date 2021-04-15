using System;

namespace binarygap
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(1041);
            
        }

        public static int solution(int N) 
        {
            //convert to string
            string binary = Convert.ToString(N, 2);

            System.Console.WriteLine(binary);

            //save needed variables
            int max = 0;

            //iterate through array, looking for 1
            for(int i=0; i<binary.Length; i++)
            {
                if(binary[i].Equals('1'))
                {
                    //when find 1,
                    //set curr max = 0
                    int currmax = 0;
                    i++;

                    //initiate while loop for 0's
                    if(i < binary.Length)
                    {
                        while(binary[i].Equals('0'))
                        {
                            //inside loop curr max ++ , i++
                            currmax++;
                            i++;
                            //check to make sure we are still inside array
                            if(i < binary.Length)
                            {
                                break;
                            }
                        }
                        if(i < binary.Length)
                        {
                            if(binary[i].Equals('1'))
                            {
                                max = currmax > max ? currmax : max;
                                //move iterator back one space as this is the start of a new test,and for loop will move it forward
                                i--;

                                if(max >= binary.Length/2)
                                {
                                    //if our max is already half the size of the binary string, we can't get a bigger sequence 
                                    break;
                                }
                            }
                        }
                    }
                    
                }
            }
            
            return max;
        }
    }
}
