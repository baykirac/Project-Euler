using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P003
    {
        public static long Prime_Number(long number)
        {
            long largest_prime = 0;
            for(long i = 2;number > 1; i++)
            {
                if (number % i == 0)
                {
                    while (number % i == 0)
                    {
                        number /= i;
                        largest_prime = i;
                    }
                }
            }
            return largest_prime;
        }   
    }
}
