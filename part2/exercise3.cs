using System;

namespace part2
{
    public class Changes
    {
        public int Calculate(int[] t)
        {
            int changes = 0;

            for (int i = 1; i <= t.Length - 1; i++)
            {
                if (t[i] == t[i - 1])
                {
                    if (i < t.Length - 1)
                    {
                        changes++;
                        // the + 1, because of a { 0, 0, 0, 0, 0 } case
                        t[i] = t[i - 1] + t[i + 1] + 1;
                    }
                    else 
                    {
                        changes++;
                        // the + 1, because of a case { ,....., 0, 0 } where 2 last elements in array are 0
                        t[i] = t[i-1] - t[i] + 1;

                    }

                }


            }
            return changes;
        }
    }
}