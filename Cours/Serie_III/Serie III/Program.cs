using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Exercice 1");
            //Console.WriteLine(" ");

            //string path = Directory.GetCurrentDirectory();
            //string input = path + @"\test.txt";
            //string output = path + @"\result.txt";
            //ClassCouncil.SchoolMeans(input, output);

            //int[] a = { 6, 4, 8, 2, 9, 3, 9, 4, 7, 6, 1 };
            //int[] b = { 6, 4, 8, 2, 9, 3, 9, 4, 7, 6, 1 };
            ////SortingPerformance.ArraysGenerator(20);
            //Console.WriteLine(SortingPerformance.UseInsertionSort(a) + "ms");
            //Console.WriteLine(SortingPerformance.UseQuickSort(b) + "ms");





            //List<int> sizes = new List<int> { 2000, 5000, 10000 };
            //int count = 10;


            
            //SortingPerformance.PerformanceTest(10, 10);

            SortingPerformance.DisplayPerformances(new List<int> { 2000, 5000, 8000 } , 10);


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
