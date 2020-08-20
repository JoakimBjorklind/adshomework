using System;

namespace part2
{
    public class Split
    {
        public int Calculate(int[] t)
        {
            /*
            // own solution below
            int leftSum = 0;

            for (int i = 0; i < t.Length; i++)
            {
                leftSum = leftSum + t[i];
            }


            int rightSum = 0;
            int count = 0;

            for (int i = t.Length - 1; i > 0; i--)
            {
              
                rightSum = rightSum + t[i];

                
                leftSum = leftSum - t[i];

                if (rightSum == leftSum)
                {
                    count++;
                    
                     
                }
                
                
                
                
            }
            return count;
            */

            int sum = 0;
            // calculate total sum of array
            foreach (int i in t)
            {
                sum = sum + i;
            }

            // if sum odd --> impossible to split!
            if (sum % 2 != 0)
            {
                return 0;
            }

            int half = sum / 2;
            int left = 0;
            int splits = 0;

            for (int i = 0; i < t.Length - 1; i++)
            {
                if (left == half)
                {
                    splits++;
                }
                if (i < t.Length)
                {
                    left = left + t[i];
                }
            }
            return splits;


        }
    }
}
