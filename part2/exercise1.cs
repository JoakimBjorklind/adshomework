using System;
using System.Text;

namespace part2

{
    public class Compare
    {
        // Case1 represents the case O(n^2)
        public int Case1(string n)
        {
            int counter = 0;

            DateTime start1 = DateTime.Now;

            for(int i = 0; i < n.Length -1; i++)
            {
                for(int j = 1; j < n.Length -1; j++)
                {
                    if (n[i].ToString() == "0" && n[j].ToString() == "1")
                    {
                        counter = counter + 1;
                    }
                }
            }

            DateTime end1 = DateTime.Now;
            Console.WriteLine("Time this took: " + end1.Subtract(start1));
            return counter;
        }

        // Case2 represents the case O(n)
        public int Case2(string n)
        {
            int counter = 0;
            int zeros = 0;

            DateTime start2 = DateTime.Now;

            for (int i = 0; i < n.Length -1; i++)
            {
                if(n[i].ToString() == "0")
                {
                    zeros = zeros + 1;
                }
                else
                {
                    counter = counter + zeros;
                }
            }

            DateTime end2 = DateTime.Now;
            Console.WriteLine("Time this took: " + end2.Subtract(start2));
            return counter;
        }

        // These exercises was run by a i3 computer.
        
        
        
        
        
        
        
        public string CreateInput(int n)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }

            return sb.ToString();

        }
    }
}