using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Euclide
    {
        public static int Pgcd(int a, int b)
        {
            //TODO
            int r;
            do
            {
                r = a % b;
                a = b;
                b = r;
            } while (r != 0);
            return a;
        }

        public static int PgcdRecursive(int a, int b)
        {
            //TODO
            int r = a % b;
            //if (r ==0)
            //{
            // return b;
            //} else
            //{
            // return PgcdRecursive(b,r);
            //}
            return r ==0 ? b : PgcdRecursive(b,r);
        }
    }
}
