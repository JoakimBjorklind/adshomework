using System;
using System.Text;

namespace part2

{
    class Program
    {
        static void Main(string[] args)
        {
            /*Compare compare = new Compare();

            string input10 = compare.CreateInput(10);
            string input100 = compare.CreateInput(100);
            string input1000 = compare.CreateInput(1000);
            string input10000 = compare.CreateInput(10000);

            compare.Case1(input10000);
            compare.Case2(input10000);
            */

            LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5
            Console.WriteLine(p.Calculate(new int[] { 0, 0, 1, 2, 2, 2, 7, 0, 0, 0, 0, 13 })); // 4

            /*
            Changes m = new Changes();
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 2, 2, 2 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 2
            */

        }
    }

}