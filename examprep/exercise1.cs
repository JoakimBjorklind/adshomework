using System;

namespace examprep
{
    public class Numbers
    {
        public int Steps(int x)
        {
            int count = 0;
            int i = 1;
            int sum = 0;

            while( sum < x)
            {
                sum = sum + i;
                i++;
                count++;
            }
            return count;
         
        }
    }
}