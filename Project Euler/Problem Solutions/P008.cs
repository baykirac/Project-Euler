using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P008
    {
        public static long find_greatest(string digits)
        {
            long greatest = 0;
            for(int i = 0; i<= digits.Length - 13; i++)
            {
                long value = 1;
                for (int j = i; j <= i + 12; j++)
                {
                    if (digits[j] != '0')
                        value *= (int)char.GetNumericValue(digits[j]);
                    else
                        break;
                }
                if (value > greatest)
                    greatest = value;
            }
            return greatest;
        }
    }
}
