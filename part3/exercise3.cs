using System;

namespace part3
{
    public class Sorting
    {
        public void MergeSort(int[] t)
        {

        }

        public void QuickSort(int[] t)
        {

        }

        public static int[] Randomizer(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                // integers between 1 and 1000 are enough for us
                arr[i] = random.Next(1, 1001);
            }
            return arr;
        }


    }
}