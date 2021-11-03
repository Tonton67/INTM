using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice 1");

            int[] array = { 1, -5, 10, -3, 0, 4, 2, -7 };
            int valeur = 2;
            Console.WriteLine(Search.LinearSearch(array, valeur));
            //Console.WriteLine(Search.LinearSearch(array, -8));
            Array.Sort(array);
            Console.WriteLine(Search.BinarySearch(array, valeur));

            Console.WriteLine("Exercice 3");

            int [] res = Eratosthene.EratosthenesSieve(100);
            foreach (int nbr in res)
            {
                if (nbr != 0)
                {
                    Console.WriteLine(nbr);
                }
            }

            //int[] array1 = new int [100];
            //Console.WriteLine(Eratosthene.EratosthenesSieve(50));





            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
