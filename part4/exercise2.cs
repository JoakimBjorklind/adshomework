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

        }
    }

}