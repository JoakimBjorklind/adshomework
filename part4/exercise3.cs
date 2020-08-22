using System;
using System.Collections.Generic;

namespace part4
{
    public class SmallestDistance
    {
        private List<int> numbers = new List<int>();
        public void Add(int x)
        {
            
            this.numbers.Add(x);

        }

        public int Calculate()
        {
            this.numbers.Sort();
            int diff = this.numbers[1] - this.numbers[0];
            // my version of the above code line --> int difference = int.MaxValue;

            for (int i = 1; i != numbers.Count; i++)
            // i != this.numbers.Count is the same as i < this.numbers.Count
            {
                int currDiff = this.numbers[i] - this.numbers[i - 1];
                if (currDiff < diff)
                {
                    diff = currDiff;
                }
                
               
            }
            return diff;

        }
    }
}