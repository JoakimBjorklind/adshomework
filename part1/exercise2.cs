using System;
using System.Text.RegularExpressions;

namespace part1
{
    public class Substrings
    {
        public int Calculate(string a, string b)
        {
            int T = a.Length;
            int P = b.Length;
            int sum = 0;
            for (int i = 0; i <= T - P; i++)
            {
                if (a[i] == b[0])
                {
                    for (int j = 0; j < P; j++)
                    {
                        if (a[i + j] == b[j])
                        {
                            if (j == P - 1)
                            {
                                sum++;
                                break;
                            }
                        }
                    }
                }



            }
            return sum;

            // Alternative solution !
            // return Regex.Matches(a, @"(?=" + b + ")").Count;

        }
    }
}