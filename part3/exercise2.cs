using System;

namespace part3
{
    public class SmallestDifference
    {
        public int Calculate(int[] t)
        {
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
        }


    }
}