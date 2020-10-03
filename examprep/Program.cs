using System;

namespace examprep {

    class Program {

        static void Main (string[] args) {

            Numbers num = new Numbers ();
            Console.WriteLine (num.Steps (11)); // 5
            Console.WriteLine (num.Steps (15)); // 5
            Console.WriteLine (num.Steps (2)); // 2

            ShortenArray s = new ShortenArray ();
            int[] array1 = { 1, 2, 2, 1, 1, 1, 3 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array3 = { 1, 1, 1, 1, 2, 2, 2, 2 };
            int[] array4 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int[] array5 = { 1, 2, 1, 1, 2, 2, 1, 1, 2, 2, 1 };
            Console.WriteLine (s.Calculate (array1)); // 1
            Console.WriteLine (s.Calculate (array2)); // 8
            Console.WriteLine (s.Calculate (array3)); // 0
            Console.WriteLine (s.Calculate (array4)); // 0
            Console.WriteLine (s.Calculate (array5)); // 3

            /*Rooms r = new Rooms ();
            int[, ] house = { { 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 1, 0, 1, 0, 0, 1 },
                { 1, 1, 1, 0, 1, 0, 1, 1 },
                { 1, 0, 1, 0, 1, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1 },
            };
            Console.WriteLine (r.Calculate (house)); // 4

            Flights f = new Flights ();
            f.AddConnection ("helsinki", "tampere", 100);
            f.AddConnection ("tampere", "oulu", 100);
            f.AddConnection ("oulu", "vaasa", 100);
            f.AddConnection ("helsinki", "turku", 500);
            f.AddConnection ("turku", "vaasa", 700);
            Console.WriteLine (l.RoutePrice ("helsinki", "vaasa")); // 1200*/

        }
    }
}