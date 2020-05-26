using System;
using System.Collections.Generic;

namespace part4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myLinks = new LinkedList();
            myLinks.AddLast(1);
            myLinks.AddFirst(2);
            myLinks.AddLast(3);
            Console.WriteLine(myLinks); // for example: 2, 1, 3
            myLinks.RemoveFirst();
            Console.WriteLine(myLinks); // for example: 1, 3
            Console.WriteLine(myLinks.GetNode(0)); // 1
            Console.WriteLine(myLinks.GetNode(1)); // 3

            /*
            CircleGame g = new CircleGame();
            Console.WriteLine(g.Last(7)); // 7
            Console.WriteLine(g.Last(4)); // 1
            Console.WriteLine(g.Last(123)); // 119

            SmallestDistance s = new SmallestDistance();
            s.Add(3);
            s.Add(8);
            Console.WriteLine(s.Calculate()); // 5
            s.Add(20);
            Console.WriteLine(s.Calculate()); // 5
            s.Add(9);
            Console.WriteLine(s.Calculate()); // 1

            Order o = new Order();
            int[] a = { 4, 2, 1, 3, 5 };
            int[] b = { 2, 4, 3, 1, 5 };
            int[] c = o.Create(a, b);
            Console.WriteLine(String.Join(" ", c)); // 2 3 5 1 4

            BinarySearchTree bs = new BinarySearchTree();
            bs.Add(5); // Becomes your root
            bs.Add(4); // Goes to the left
            bs.Add(6); // Goes to the right
            Console.WriteLine(bs.Height()); // 1
            bs.Add(3);
            bs.Add(1);
            bs.Add(7);
            Console.WriteLine(bs.Height()); // 3
            */

        }

    }

}
