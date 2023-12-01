using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P002
    {
        public static int Even_Valued_Fibo(int limit)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            int result = 0;
            while(c < limit)
            {
                c = a + b;
                a = b;
                b = c;
                if (c % 2 == 0)
                    result += c;
            }
            return result;
        }
    }
}
