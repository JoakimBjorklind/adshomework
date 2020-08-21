using System;

namespace part3
{
    public class Inversions
    {
        public int[] Create(int n, int k)
        {
           /*
           // own solution below
           int [] array = new int [n];

           for (int i = 0; i < n; i++)
           {
               array[i] = i+1;
           }

           int inversionsCount = 0;
           int a = 0;
           int b = (n-1);

           while(inversionsCount < k)
           {
               int temp = array[b];
               array[b] = array[b-1];
               array[b-1] = temp;

               inversionsCount++;
               b--;
               if(b == a)
               {
                   b = (n-1);
                   a++;
               }

           }
           return array;
           */

           int maxInversions = (n * (n - 1)) / 2;

           if (k > maxInversions)
           {
               k = maxInversions;
           }

           // Create new result array
           int[] result = new int[n];

           for (int i = 1; i <= n; i++)
           {
               result[i - 1] = i;
           }

           // how many inversions have been done
           int inversions = 0;
           // get last index
           int latest = (n - 1);
           // lowest index visited
           int lowest = 0;

           while (inversions < k)
           {
               // swap latest and the one before it
               int temp = result[latest];
               result[latest] = result[latest - 1];
               result[latest - 1] = temp;

               inversions++;
               latest--;

               if (latest == lowest)
               {
                   latest = (n - 1);
                   lowest++;
               }
           }
           return result;





        }
        
    }
}