using System;
using System.Text.RegularExpressions;

namespace part1
{
    public class Substrings
    {
        public int Calculate(string a, string b)
        {
            int P = b.Length;
            int T = a.Length;
            int sum = 0;
            for (int i = 0; i <= T - P; i++)
            {
                int j;
                for (j = 0; j < P; j++)
                {
                    if (a[i+j] != b[j])
                    {
                        break;
                    }
                }
                if (j ==P)
                {
                    sum++;
                    j = 0;
                }
            }
            return sum;
            
        }
    }
}