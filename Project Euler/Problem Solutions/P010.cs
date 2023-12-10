using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P010
    {
        public static long find_prime()
        {
            long sum = 0;
            for(int i = 0; i < 2000000; i++)
            {
                if(isprime(i))
                    sum += i;
            }
            return sum;
        }
        private static bool isprime(int num)
        {
            if (num < 2) return false;
            if (num % 2 == 0) return (num == 2);
            for (int i = 3; i <= (int)Math.Sqrt((double)num); i+=2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
