using System;

namespace part2
{
    public class Changes
    {
        public int Calculate(int[] t)
        {
            int changes = 0;
            // i < t.Length; is the same as i <= t.Length -1;
            for (int i = 1; i <= t.Length -1; i++)
            {
                if (t[i] == t[i - 1])
                {
                    changes++;
                    if (i < t.Length - 1)
                    {
                        
                        // the + 1, because of a { 0, 0, 0, 0, 0 } case
                        t[i] += t[i - 1] + t[i + 1] + 1;
                    }
                    else 
                    {
                        
                        // the + 1, because of a case { ,....., 0, 0 } where 2 last elements in array are 0
                        t[i] = t[i-1] + t[i] + 1;

                    }

                }


            }
            return changes;
        }
    }
}