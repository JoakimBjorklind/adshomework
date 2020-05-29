using System;
using System.Collections.Generic;

namespace part4
{
    public class SmallestDistance
    {
        List<int> numbers = new List<int>();
        public void Add(int x)
        {
            
            numbers.Add(x);

        }

        public int Calculate()
        {
            numbers.Sort();

            int difference = int.MaxValue;

            for (int i = 1; i != numbers.Count; i++)
            {
                
                {
                    if (((numbers[i] - numbers[i-1]) < difference))
                    {
                        difference = numbers[i] - numbers[i-1];
                    }
                }
            }
            return difference;

        }
    }
}