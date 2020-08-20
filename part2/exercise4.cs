using System;

namespace part2
{
    public class Revolutions
    {
        public int Calculate(int[] t)
        {
            /*
            // own solution below
            int n = 0;

            for(int j = 0; j < t.Length -1; j++)
            {
                if (t[j] > n)
                {
                    n = t[j];
                }
            }
            int needPickUp = 1;
            int revolutions = 0;

            while (needPickUp <= n)
            {
               
                for (int i = 0; i <= t.Length - 1; i++)
                {
                    if (t[i] == needPickUp)
                    {
                        needPickUp++;
                    }
                }
                revolutions++;

               
            }
            return revolutions;
            */
            int rev = 0;
            int search = 1;

            while (true)
            {
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] == search)
                    {
                        search++;
                    }

                }
                rev++;
                if (search > t.Length)
                {
                    break;
                }
            }
            return rev;
        }
    }






}
