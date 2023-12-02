using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solutions
{
    internal class P005
    {
        public static int smallest_Multipe()
        {
            int number = 1;
            bool isSmallest = false;
            while (true)
            {
                for(int i = 1 ; i <= 20; i++)
                {
                    if(number % i != 0)
                    {
                        isSmallest = false;
                        break;
                    }
                    else
                        isSmallest = true;
                }
                if (isSmallest)
                    return number;
                number++;
            }
        }
    }
}
