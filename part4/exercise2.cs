using System;
using System.Collections.Generic;

namespace part4
{
    public class CircleGame
    {
        
        public int Last(int n)
        {
           if (n == 1)
           {
               return 1;
           }
           if (n % 2 == 0)
           {
               return 2 * Last(n/2) - 1;
           }
           else
           {
               return 2 * Last((n-1) / 2) + 1;
           }

           /*
           // own solution below with the mathematical formula, short and only 4 lines of code!!
           int p = 1;
           while (p <= n)
           {
               p *= 2;
           }
           return (2 * n) - p + 1;
           */

        }
    }

}