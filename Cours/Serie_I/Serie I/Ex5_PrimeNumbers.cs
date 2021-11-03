using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class PrimeNumbers
    {
        static bool IsPrime(int valeur)
        {
            //TODO
            for (int i = 2; i <= Math.Sqrt(valeur); i++)
            {
                if (valeur % i == 0)
                {
                    return false;
                }

            }
            return true;

        }

        public static void DisplayPrimes()
        {
            //TODO
            for (int i = 1; i < 100; i++)
            {

                if (IsPrime(i))
                {
                    Console.WriteLine($"{i} est un nombre premier.");
                }
            }

        }
    }
}
