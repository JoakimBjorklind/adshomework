using System;

namespace part1
{
    public class Numbers
    {
        public int Sum(int x)
        {
           // this works for all integers x (both negative and positive), bcs of the absolute value!
           x = Math.Abs(x);
           int sum = 0;
           while (x != 0)
           {
               sum += x % 10;
               x /= 10;
                
           }
           return sum;
        }
    }
}