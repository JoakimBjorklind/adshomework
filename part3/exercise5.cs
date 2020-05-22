using System;

namespace part3
{
    public class Inversions
    {
        public int[] Create(int n, int k)
        {
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



        }
        
    }
}