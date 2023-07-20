using System;
using System.Collections;
using System.Collections.Generic;

namespace main
{
    class Soal1
    {
        static int SlouanesOEIS(int n)
        {

            return n * (n + 1) / 2 + 1;

        }

        public static string DeretSlouanesOEISToN(int n)
        {
            string result = "";
            for(int i = 0; i < n; i++)
            {
                result += SlouanesOEIS(i).ToString();
                if(i != n - 1)
                {
                    result += "-";
                }
            }

            return result;
        }
    }
}