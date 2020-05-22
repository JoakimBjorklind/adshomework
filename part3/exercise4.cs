using System;

namespace part3
{
    public class BinarySearch
    {
        public bool Find(int[] t, int x)
        {
            Array.Sort(t);
            int a = 0;
            int b = t.Length;
            while(a <= b)
            {
                int k = (a+b)/2;
                if (x==t[k])
                {
                    return true;
                }
                if (x < t[k])
                {
                    b = k-1;
                }
                if (x > t[k])
                {
                    a = k+1;
                }

            }

             return false;
        }


    }
}