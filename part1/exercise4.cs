using System;
using System.Collections.Generic;

namespace part1

{
    public class LuckyNumbers

    {
        // This formula returns the right amount of luckynumbers for every interval (a,b).
        // for example luckynumbers in the interval (33,37) returns 2 with this.
        public int Calculate(int a, int b)
        {
            return CalculateLuckyNumbers(b) - CalculateLuckyNumbers(a - 1);
        }
        public int CalculateLuckyNumbers(int a)
        {
            long b = Convert.ToInt64(a);

            // list for holding numbers, order and amount
            List<long> list = new List<long>();

            if (b >= 3L)
            {
                // add 3 to list if >= 3
                list.Add(3L);
            }
            // if < 3 nothing will match
            else
            {
                return 0;
            }

            // Same for 7 after that 3 has been checked
            if (b >= 7L)
            {
                list.Add(7L);
            }
            else
            {
                return 1;
            }

            // rest of numbers are based on the two previous ones
            int i = 0;
            while (true)
            {

                // get index i, multiply by 10 and add 3
                long x = list[i] * 10 + 3;
                // get index i, multiply by 10 and add 7
                long y = list[i] * 10 + 7;
                // if 1:st number over the limit, then break
                if (x > b)
                {
                    break;
                }
                list.Add(x);
                // same for the 2:nd number
                if (y > b)
                {
                    break;
                }
                list.Add(y);
                // go and check the next index
                i++;
            }
            // last return the list
            return list.Count;





        }










    }
}