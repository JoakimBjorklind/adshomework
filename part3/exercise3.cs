using System;

namespace part3
{
    public class Sorting
    {
        public void MergeSort(int[] t)
        {
            DateTime start = DateTime.Now;

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));

        }

        public void QuickSort(int[] t)
        {
            DateTime start2 = DateTime.Now;

            DateTime end2 = DateTime.Now;
            Console.WriteLine("Time this took: " + end2.Subtract(start2));

        }




    }
}