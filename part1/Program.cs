using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Substrings subs = new Substrings();
            subs.Calculate("aybabtu", "bab");
            subs.Calculate("aaaaa", "aa");
            subs.Calculate("monkey", "banana");
            Console.WriteLine(subs.Calculate("aybabtu", "bab"));
            Console.WriteLine(subs.Calculate("aaaaa", "aa"));
            Console.WriteLine(subs.Calculate("monkey", "banana"));
        }
    }
}