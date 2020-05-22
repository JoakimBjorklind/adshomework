using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintHello printHello = new PrintHello();
            printHello.Hello(5);
            
            Console.WriteLine();
            
            SmallestDifference s = new SmallestDifference();
            Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
            Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
            Console.WriteLine(s.Calculate(Randomizer(10))); // depends on random 
            
            Console.WriteLine();
            

            /*
            Sorting s = new Sorting();
            int[] sortMe = Randomizer(100);
            int[] sortMeLarge = Randomizer(1000000);
            s.QuickSort(sortMe);
            s.MergeSort(sortMe);
            s.QuickSort(sortMeLarge);
            s.MergeSort(sortMeLarge);
            */
            

            
            
            BinarySearch b = new BinarySearch();
            Console.WriteLine(b.Find((new int[] { 4, 1, 8, 5 }), 2)); // false
            Console.WriteLine(b.Find((new int[] { 0, 0 }), 0)); // true
            Console.WriteLine(b.Find((new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }), 2)); // true
            Console.WriteLine(b.Find((new int[] { 0 }), 0)); // true
            
            Console.WriteLine(b.Find((Randomizer(10)), 3)); // ?
            
            Console.WriteLine();
            
            

            
            Inversions inv = new Inversions();
            int[] t = inv.Create(5, 2);
            foreach (int i in t)
            {
                Console.Write(i + " ");  // 2 1 3 5 4
            }
            


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