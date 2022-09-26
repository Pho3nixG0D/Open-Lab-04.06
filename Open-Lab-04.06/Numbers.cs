using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int countl = 0;
            int x = 0;
            for (int i = 0; i < numbers.Length ; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    countl++;
                }
            }
            int[] resultArray = new int[countl];

            for (int i = 0; i < numbers.Length ;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    resultArray[x] = numbers[i];
                    x++;
                }
            }
            return resultArray;

        }
    }
}
