using System;

namespace part2
{
    public class Split
    {
        public int Calculate(int[] t)
        {
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
            
            
        }
    }
}
