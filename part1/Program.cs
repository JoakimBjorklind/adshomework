using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            Console.WriteLine(num.Sum(4075));
            Console.WriteLine(num.Sum(3));
            Console.WriteLine(num.Sum(999999999));
        }
    }
}