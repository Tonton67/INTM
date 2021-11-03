using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            char operation = '+';
            ElementaryOperations.BasicOperation(a, b, operation);

            operation = '-';
            ElementaryOperations.BasicOperation(a, b, operation);

            operation = '*';
            ElementaryOperations.BasicOperation(a, b, operation);

            operation = '/';
            ElementaryOperations.BasicOperation(a, 0, operation);

            operation = '/';
            ElementaryOperations.BasicOperation(a, b, operation);

            operation = 'L';
            ElementaryOperations.BasicOperation(a, b, operation);


            a = 10;
            b = 7;
            ElementaryOperations.IntegerDivision(a, b);

            a = 10;
            b = 0;
            ElementaryOperations.Pow(a, b);


            int heure = 28;
            string msg=SpeakingClock.GoodDay(heure);

            Console.WriteLine(SpeakingClock.GoodDay(DateTime.Now.Hour));

            int n = 10;
            Factorial.Factorial_(n);
            Console.WriteLine(Factorial.Factorial_(10));


            Pyramid.PyramidConstruction(10,false);

            PrimeNumbers.DisplayPrimes();


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
