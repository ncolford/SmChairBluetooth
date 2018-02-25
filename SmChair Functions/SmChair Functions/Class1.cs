using System;

namespace SmChair_Functions
{
    //Any structures needed can go in her
    public struct Time_Data
    {
        public int[] S1, S2, S3, S4, S5, S6, S7;
        public string[] TS1, TS2, TS3, TS4, TS5, TS6, TS7;
        public int curr1, curr2, curr3, curr4, curr5, curr6, curr7;
        public Time_Data(int len)   //This is the constructor for this structure, it is a included initializer
        {
            S1 = new int[len];
            S2 = new int[len];
            S3 = new int[len];
            S4 = new int[len];
            S5 = new int[len];
            S6 = new int[len];
            S7 = new int[len];

            TS1 = new string[len];
            TS2 = new string[len];
            TS3 = new string[len];
            TS4 = new string[len];
            TS5 = new string[len];
            TS6 = new string[len];
            TS7 = new string[len];

            curr1 = 0; curr2 = 0; curr3 = 0; curr4 = 0; curr5 = 0; curr6 = 0; curr7 = 0;
        }
    };
    public class SmChairFunc
    {
        //Any functions needed can go in here!
        //To use them in proj, use SmFunc.FUNCTIONNAME()
        //To make them, public outputs FUNCTIONNAME(inputs)
    }
}
