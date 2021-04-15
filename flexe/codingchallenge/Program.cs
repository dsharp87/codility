using System;
using System.Collections.Generic;

namespace codingchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(solution(2, "1A 2B"));
            solution(2, "1A 2B");
        }

        public static int solution(int N, String S)
        {
            if(String.Equals(S, String.Empty))
            {
                return 3*N;
            }
            //split incomming string array into seats
            string[] seats = S.Split(" ");

            //how to store these
            //arrry of arrays per row [[xxx],[xxxx],[xxx]],[1]

            int[][][] chart = new int[N][][];
            for(int i =0; i < N; i++)
            {
                chart[i] = new int[3][];
                chart[i][0] = new int[3];
                chart[i][1] = new int[4];
                chart[i][2] = new int[3];
            }

     

            Dictionary<string,int> charmap = new Dictionary<string, int>();
            charmap.Add("A",0);
            charmap.Add("B",1);
            charmap.Add("C",2);
            charmap.Add("D",0);
            charmap.Add("E",1);
            charmap.Add("F",2);
            charmap.Add("G",3);
            charmap.Add("H",0);
            charmap.Add("J",1);
            charmap.Add("K",2);

            //place seats in chart
            //iterate through each seat,
            //first (char or 2) - 1 = chart[]
            //letter  = seat, parse it to a value

            foreach(string seat in seats)
            {
                string letter = seat.Substring(seat.Length-1);
                string stringrow = "";
                if(seat.Length == 2)
                {
                    stringrow = seat[0].ToString();
                }
                else
                {
                    stringrow = seat[0].ToString() + seat[1].ToString();
                }
                int rownum = Int32.Parse(stringrow);

                //place 1 in spot on chart
                int rowsection = -1;
                if(String.Equals(letter, "A") || String.Equals(letter, "B") || String.Equals(letter, "C"))
                {
                    rowsection = 0;
                }
                else if(String.Equals(letter, "D") || String.Equals(letter, "E") || String.Equals(letter, "F") || String.Equals(letter, "G"))
                {
                    rowsection = 1;
                }
                else
                {
                    rowsection = 2;
                }

                //set chart val
                chart[rownum-1][rowsection][charmap[letter]] = 1;
            }

            int result = 0;
            for(int row = 0; row < chart.Length; row++)
            {
                for(int section = 0; section < chart[row].Length; section++)
                {
                    if(chart[row][section].Length == 3)
                    {
                        if(Array.IndexOf(chart[row][section],1) != -1)
                        {
                            result++;
                        }
                        else
                        {
                            if(chart[row][section][1] == 1 || chart[row][section][2] == 1)
                            {
                                continue;
                            }
                            else if(chart[row][section][0] == 0 || chart[row][section][3] == 0)
                            {
                                result++;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
