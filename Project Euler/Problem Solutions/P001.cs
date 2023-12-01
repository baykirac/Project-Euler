using System;
using System.Reflection.Metadata;

namespace Project_Euler.Problem_Solutions
{
    internal class P001
    {
        public static int Multiple_3_5(int below)
        {
            int result = 0;
            for(int i = 0; i < below; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
