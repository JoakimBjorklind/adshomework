using System;

namespace part3
{
    public class Sorting
    {
        public void MergeSort(int[] t)
        {

            DateTime start = DateTime.Now;

            int[] sorted = new int[t.Length];

            sorted = SortMergeAlternative(t);

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));

        }

        public void QuickSort(int[] t)
        {
            DateTime start = DateTime.Now;

            SortQuickAlternative(t, 0, t.Length - 1);

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));

        }

        public int[] SortMergeAlternative(int[] t)
        {

            if (t.Length <= 1)
            {
                return t;
            }

            int a = 0;
            int b = t.Length - 1;
            int k = (a + b) / 2;

            int[] leftArray = new int[k];
            int[] rightArray = new int[b - k];

            for (int i = 0; i < k; i++)
            {
                leftArray[i] = t[i];
            }
            for (int i = k; i < t.Length - 1; i++)
            {
                rightArray[i - k] = t[i];
            }

            leftArray = SortMergeAlternative(leftArray);
            rightArray = SortMergeAlternative(rightArray);

            return MergePart(leftArray, rightArray);





        }

        public int[] MergePart(int[] a, int[] b)
        {
            int[] mergedArray = new int[a.Length + b.Length];
            int[] helpArray = new int[a.Length + b.Length];

            int a1 = 0;
            int a2 = 0;
            int b1 = a.Length - 1;
            int b2 = b.Length - 1;

            for (int i = 0; i <= (a.Length + b.Length) - 1; i++)
            {
                if ((a2 > b2) || ((a1 <= b1) && (a[a1] <= b[a2])))
                {
                    helpArray[i] = a[a1];
                    a1++;
                }
                else
                {
                    helpArray[i] = b[a2];
                    a2++;
                }
            }

            for (int i = 0; i <= (a.Length + b.Length) - 1; i++)
            {
                mergedArray[i] = helpArray[i];
            }



            return mergedArray;

        }

        public void SortQuickAlternative(int[] t, int a, int b)
        {
            if (a >= b)
            {
                return;
            }

            int k = Pivot(t, a, b);

            SortQuickAlternative(t, a, k - 1);
            SortQuickAlternative(t, k + 1, b);


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
            int swap2 = t[k];
            t[k] = t[a];
            t[a] = swap2;

            return k;
        }








    }
}