using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P007
    {
        public static int prime_of_10001()
        {
            int prime_number = 0, count = 2, prime_counter = 0;
            while (true)
            {
                bool isPrime = true;
                for(int i = 2;i < count; i++)
                {
                    if (count % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    prime_counter++;
                    if(prime_counter == 10001)
                    {
                        prime_number = count;
                        return prime_number;
                    }
                }
                count++;
            }
        }
    }
}
