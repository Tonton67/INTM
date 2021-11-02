using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Factorial
    {
        public static int Factorial_(int n)
        {
            //TODO
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x *= i;
            //Console.WriteLine($"x = {x} ; n = {n}");
            }
            return x;
        }

        public static int FactorialRecursive(int n)
        {
            //TODO
            if (n > 1)
            {
                return n * FactorialRecursive(n - 1);
            }
            else
            {
                return 1;
            }
            //return > 1 ? n * FactorialRecursive(n - 1) : 1;
        }
    }
}
