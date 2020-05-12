using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            LuckyNumbers luck = new LuckyNumbers();
            Console.WriteLine(luck.Calculate(10,100));
        }
    }
}