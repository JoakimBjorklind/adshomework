using System;
using System.Text;

namespace part2

{
    public class Compare
    {
        
        
        
        
        
        
        
        public string CreateInput(int n)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }

            return input;

        }
    }
}