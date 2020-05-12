using System;
using System.Collections.Generic;

namespace part1

{
    public class LuckyNumbers
    {
        /*First step is to break the whole sequence 3,7,33,37,73,77,... into 2 smaller sub-sequences:
        3,33,37,333,337,373,377,... and 7,73,77,733,737,773,777,...  Looking closer at these sub-sequneces
        one see that there is a pattern in them. 3*10 + 3 = 33, 3*10 + 7 = 37, 33*10 + 3 = 333, 33*10 + 7 = 337,
        Same with the other sub-sequence: 7*10 + 3 = 73, 7*10 + 7 = 77, 73*10 + 3 = 733, 73*10 + 7 = 737.
        Lets give the terms in the first subsequence: a_1,a_2,a_3,... where a_1 = 3, a_2 = 33,....
        the following recursion formula exist:

        a_2 = a_1 * 10 + 3     (33)
        a_3 = a_1 * 10 + 7     (37)
        a_4 = a_2 * 10 + 3     (333)
        a_5 = a_2 * 10 + 7     (337)

        more general:

        a_k+1 = a_k * 10 + 3
        a_k+2 = a_k * 10 + 7
        a_k+3 = a_k+1 * 10 + 3
        a_k+4 = a_k+1 * 10 + 7     for k = 1,2,3,...

        The formula is the same for the other sub-sequence too starting with 7,73,77,...

        There is also a sequnece for the whole sequence: 3,7,33,37,73,77,..
        Let a_1 = 3, a_2 = 7, a_3 = 33,....

        a_k+2 = a_k * 10 + a_1
        a_k+3 = a_k * 10 + a_2
        a_k+4 = a_k+1 * 10 + a_1
        a_k+5 = a_k+1 * 10 + a_2
        a_k+6 = a_k+2 * 10 + a_1
        a_k+7 = a_k+2 * 10 + a_2

        Can also be written as

        a_k+2 = a_k * 10 + 3
        a_k+3 = a_k * 10 + 7   and the same way for the other terms too since a_1 = 3, a_2 = 7.

        A general formula for this one: a_2n+1 = a_n * 10 + 3, n = 1,2,3,... for even terms in the sequence and
        a_2n+2 = a_n * 10 + 7, for n = 1,2,3,... for odd terms in the sequence.
        
        In the exercise we have an interval between (a,b). The idea is to first loop through the interval (0,b)
        and find out how many luckynumbers there are in the interval. And then do the same thing for interval(0,a)
        Then substract the amount of luckynumbers in int (0,a) from (0,b) to get the total amount of 
        luckynumbers in interval (a,b)

        I was thinking of doing this with an for-loop. Now the tricky part is getting the recursion formula
        into the for-loop. the program should add 1 (luckyNumbers++;) each time the loop hit a value on the 
        recursion formula. And that way the luckynumbers are counted in an interval.



        */

        public int CalculateLuckyNumbers(int a, int b)
        {


            List<int> aluckyNumbers = new List<int>(); // luckynumber list for (1,a)
            List<int> bluckyNumbers = new List<int>(); // luckynumber list for (1,b)
            // did not understand this part where the .Add(3) and .Add(7) should have been added.
            if (a < 3 && b > 3)
            {

                return 0;
            }
            if (a >= 3 && b < 7)
            {
                aluckyNumbers.Add(3);
                return 1;
            }
            if (a >= 3 && b <= 7)
            {
                return 2;
            }
            aluckyNumbers.Add(3);
            aluckyNumbers.Add(7);
            bluckyNumbers.Add(3);
            bluckyNumbers.Add(7);

            // doing the while-loop first for interval(1,a)
            int i = 0;
            while (true)
            {

                // i = 0 gives 10*0 + 3 = 3, i+1 gives 10*3 + 3 = 33, i+2 gives 10*3 + 7 = 37,...
                i + 1 = 10 * i + 3;
                i + 2 = 10 * i + 7;

                // breaking the loop if i+1 term or i+2 term is too big
                if (i + 1 > a)
                {
                    break;
                }
                if (i + 2 > a)
                {
                    break;
                }
                i++;


            }
            // return the counts of the luckynumbers in interval(1,a)
            return aluckyNumbers.Count;

            
            // doing the same while-loop for interval (1,b)
            int j = 0;
            while (true)
            {

                // j = 0 gives 10*0 + 3 = 3, j+1 gives 10*3 + 3 = 33, j+2 gives 10*3 + 7 = 37,...
                j + 1 = 10 * i + 3;
                j + 2 = 10 * i + 7;

                // breaking the loop if i+1 term or i+2 term is too big
                if (j + 1 > b)
                {
                    break;
                }
                if (j + 2 > b)
                {
                    break;
                }
                j++;


            }
            // return the counts of luckynumbers in interval (1,b)
            return bluckyNumbers.Count;

        }



        // This formula returns the right amount of luckynumbers for every interval (a,b).
        // for example luckynumbers in the interval (33,37) returns 2 with this.
        public int Calculate(int a, int b)
        {
            return CalculateLuckyNumbers(b) - CalculateLuckyNumbers(a - 1);
        }






    }
}