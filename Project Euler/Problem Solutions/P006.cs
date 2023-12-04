using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P006
    {
        public static long difference_between()
        {
            long sum_of_squares = 0, square_of_sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum_of_squares += Convert.ToInt64(Math.Pow(i, 2));
                square_of_sum += i;
                
            }
            square_of_sum *= square_of_sum;
            return square_of_sum - sum_of_squares;
        }
    }
}
