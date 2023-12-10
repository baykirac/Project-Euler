using System;

namespace Project_Euler.Problem_Solutions
{
    internal class P009
    {
        public static double special_pythagorean_triplet()
        {
            int a, b, c = 1000;
            for(a = 1; a < c; a++)
            {
                for(b = a + 1; b < c; b++)
                {
                    c = 1000 - a - b;
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        return a * b * c;
                }
            }
            return 0;
        }
    }
}
