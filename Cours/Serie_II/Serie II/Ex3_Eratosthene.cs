using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Eratosthene
    {
        public static int[] EratosthenesSieve(int n)
        {
            //TODO
            int[] array = new int[n + 1];
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i;
            }
                for (int j = 2; j < Math.Sqrt(n); j++)
                {
                    if (array[j] != 0)
                    {
                        for (int multiple = 2 * j; multiple < array.Length; multiple += j)
                        {
                            if (array[multiple] != 0)
                            {
                                array[multiple] = 0;
                            }

                        }

                    }
                }
            
            return array;
        }
    }
}
