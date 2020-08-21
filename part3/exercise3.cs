using System;

namespace part3
{
    public class Sorting
    {
        public void MergeSort(int[] t)
        {

            DateTime start = DateTime.Now;

            t = MergeSorter(t);

            DateTime end = DateTime.Now;
            Console.WriteLine("Mergesort, Array of " + t.Length + ":\t Time: " + end.Subtract(start));

        }
        public int[] MergeSorter(int[] t)
        {

            int a = 0;
            int b = t.Length;
            int k = (a + b) / 2;

            int[] left = new int[k];
            int[] right = new int[b - k];

            if (t.Length == 1)
            {
                return t;
            }

            for (int i = 0; i <= t.Length - 1; i++)
            {
                if (i < k)
                {
                    left[i] = t[i];
                }
                else
                {
                   right[i - k] = t[i]; 
                }
            }
            
            left = MergeSorter(left);
            right = MergeSorter(right);

            return Merge(left, right);

        }

        public int[] Merge(int[] a, int[] b)
        {
            int totalLength = a.Length + b.Length;
            int[] result = new int[totalLength];
            int[] helper = new int[totalLength];

            int a1 = 0;
            int a2 = 0;
            int b1 = a.Length - 1;
            int b2 = b.Length - 1;

            for (int i = 0; i <= totalLength - 1; i++)
            {
                if (a2 > b2 || (a1 <= b1 && (a[a1] <= b[a2])))
                {
                    helper[i] = a[a1];
                    a1++;
                }
                else
                {
                    helper[i] = b[a2];
                    a2++;
                }
            }

            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = helper[i];
            }

            return result;

        }

        public void QuickSort(int[] t)
        {
            DateTime start = DateTime.Now;

            t = QuickSorter(t, 0, t.Length - 1);

            DateTime end = DateTime.Now;
            Console.WriteLine("QuickSort, Array of  " + t.Length + ":\t Time: " + end.Subtract(start));

        }


        public int[] QuickSorter(int[] t, int a, int b)
        {
            if (a >= b)
            {
                return t;
            }

            int k = Pivot(t, a, b);

            QuickSorter(t, a, k - 1);
            QuickSorter(t, k + 1, b);

            return t;


        }

        public int Pivot(int[] t, int a, int b)
        {
            int k = a;

            for (int i = a + 1; i <= b; i++)
            {
                if (t[i] < t[a])
                {
                    k++;

                    int swap = t[k];
                    t[k] = t[i];
                    t[i] = swap;
                }

            }
            int temp = t[k];
            t[k] = t[a];
            t[a] = temp;

            return k;
        }








    }
}