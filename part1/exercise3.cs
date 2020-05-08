using System;
using System.Collections.Generic;
namespace part1
{
    public class Tables
    {
        public int Calculate(int[] t)
        {
           // hints for the exercise 3
           /* if t.length == 1
            return only item in the tables
            else
            int[]  newarray = ... int[t.length -1]
            for each number in t until t.length -1
            t[i] +[t+1]
            add sum of newarray
            return Calculate(newarray)
           */
           
           if (t.Length == 1)
           {
               return t[0];
           }

           else
           {
               int[] newArray = new int[t.Length -1];

               for (int i = 0; i < t.Length -1; i++)
               {
                   
                   newArray[i] = t[i] + t[i+1]; 
                   
               }
               return Calculate(newArray);
           }
           
        }
    }
}