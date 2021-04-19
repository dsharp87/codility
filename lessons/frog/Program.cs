using System;

namespace frog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //comments!

        public static int solution(int X, int Y, int D) 
        {
            int jumps = 0;
            while(X < Y)
            {
                X+= D;
                jumps++;
            }
            return jumps;
        }
    }
}
