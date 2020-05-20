using System;

namespace part3
{
    public class PrintHello
    {
        // Pseudocode version from part1 text material
        /*
        void Hello(n)
          if n == 0
            return
          else
            print("Hello!")
            Hello(n-1)

        */



        public void Hello(int n)
        {
          if (n == 0)
          {
            return;
          }
          else
          {
            Console.WriteLine("Hello!");
            Hello(n-1);
          }

        }
    }
}