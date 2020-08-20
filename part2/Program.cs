using System;
using System.Text;

namespace part2

{
    class Program
    {
        static void Main(string[] args)
        {
            Compare compare = new Compare();

            string input10 = compare.CreateInput(10);
            string input100 = compare.CreateInput(100);
            string input1000 = compare.CreateInput(1000);
            string input10000 = compare.CreateInput(10000);

            Console.WriteLine("Case1, the inefficient version");

            compare.Case1(input10);
            compare.Case1(input100);
            compare.Case1(input1000);
            compare.Case1(input10000);

            Console.WriteLine("Case2, the efficient version");

            compare.Case2(input10);
            compare.Case2(input100);
            compare.Case2(input1000);
            compare.Case2(input10000);
            
            Console.WriteLine();
            
            LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5
            Console.WriteLine(p.Calculate(new int[] { 0, 0, 1, 2, 2, 2, 7, 0, 0, 0, 0, 13 })); // 4
            
            
            

            Console.WriteLine();
            
            Changes m = new Changes();
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 2, 2, 2 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 0, 0, 0, 1, 1, 1, 0, 0 })); // 3
            Console.WriteLine(m.Calculate(new int[] { 0, 0, 0, 0, 0 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 0, 0, 0, 0 })); // 2
            
            Console.WriteLine();
            
            Revolutions r = new Revolutions();
            Console.WriteLine(r.Calculate(new int[] { 4, 1, 3, 2, 5 })); // 3
            Console.WriteLine(r.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(r.Calculate(new int[] { 5, 4, 3, 2, 1 })); // 5
            Console.WriteLine(r.Calculate(new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10})); //5
            
            Console.WriteLine();
            
            Split s = new Split();
            Console.WriteLine(s.Calculate(new int[] { 1, 2, -1, 4, 0 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(s.Calculate(new int[] { 0, 0, 0, 0, 0 })); // 4
            Console.WriteLine(s.Calculate(new int[] { 2, 2, 2, 2, 2, 2 })); // 1
            

        }
    }

}