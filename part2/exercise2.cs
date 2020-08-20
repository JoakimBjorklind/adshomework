using System;

namespace part2
{
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            /*
            // own solution below
            // set the longest rep. to 0 in beginning, could also be one.
            int longestRepetion = 0;
            int repetion = 1;

            for (int i = 0; i < t.Length -1; i++)
            {
               // calculating the current longest repetition
               if (t[i] == t[i+1])
               {
                  repetion++;
               }
               else
               {
                  repetion = 1;
               }
               // this gives the biggest repetition on the whole sequence
               if ( repetion > longestRepetion)
               {
                  longestRepetion = repetion;
               }

            }

            return longestRepetion;
            */
            int count = 1;
            int max = 1;

            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] == t[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > max)
                {
                    max = count;
                }
            }
            return max;

        }
    }
}