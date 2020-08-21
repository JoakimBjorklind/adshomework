using System;

namespace part3
{
    public class SmallestDifference
    {
        public int Calculate(int[] t)
        {
            /*
            // own solution below
            Array.Sort(t);

            int difference = int.MaxValue;

            for (int i = 0; i < t.Length - 1; i++)
            {
                
                {
                    if (((t[i+1] - t[i]) < difference))
                    {
                        difference = t[i+1] - t[i];
                    }
                }
            }
            return difference;
            */
            Array.Sort(t);
            int diff = t[1] - t[0];
            
            for (int i = 1; i < t.Length; i++)
            {
                int currDiff = t[i] - t[i-1];
                if(currDiff < diff)
                {
                    diff = currDiff;
                }
            }
            return diff;
        }


    }
}