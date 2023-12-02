using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P004
    {
        public static int polindrome()
        {
            int r, largest = 0, sum = 0, n, temp;
            for(int i = 100; i <= 999; i++)
            {
                for(int j = 100; j <= 999; j++)
                {
                    n = i * j;
                    temp = n;
                    sum = 0;
                    while (n > 0)
                    {
                        r = n % 10;
                        sum = (sum * 10) + r;
                        n = n / 10;
                    }
                    if (temp == sum && temp > largest)
                        largest = temp;
                }
            }
            return largest;
        }

    }
}
