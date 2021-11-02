using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();

            Console.WriteLine("Hello " + fname + " !");


            fname = "Toto";
            Console.WriteLine($"Hello {fname} ! {fname.Length}");


            int i = 5;
            int j = 2;

            if (i > j)
            {
                Console.WriteLine($"i > j");
            }
            else if (i < j)
            {
                Console.WriteLine($" i < j");
            }
            else
            {
                Console.WriteLine($" i = j");
            }



            Console.ReadKey();

                }
    }
}
