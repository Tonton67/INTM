using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Search
    {
        public static int LinearSearch(int[] tableau, int valeur)
        {
            //TODO
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] == valeur)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch(int[] tableau, int valeur)
        {
            //TODO

            if (tableau.Length > 0)
            {
                int max = tableau.Length;
                int min = 0;
                int mil = tableau.Length / 2;
                while (min <= max)
                {

                    if (tableau[mil] == valeur)
                    {
                       return mil;
                    }
                    else if (tableau[mil] > valeur)
                    {
                        max = mil - 1;
                    }
                    else
                    {
                        min = mil + 1;
                    }
                    mil = (max + min) / 2;
                }

            }





            return -1;
        }
    }
}
