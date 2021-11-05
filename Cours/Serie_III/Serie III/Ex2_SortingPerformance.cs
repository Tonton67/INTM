using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct SortData
    {
        /// <summary>
        /// Moyenne pour le tri par insertion
        /// </summary>
        public long InsertionMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri par insertion
        /// </summary>
        public long InsertionStd { get; set; }
        /// <summary>
        /// Moyenne pour le tri rapide
        /// </summary>
        public long QuickMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri rapide
        /// </summary>
        public long QuickStd { get; set; }
    }

    public static class SortingPerformance
    {
        public static void DisplayPerformances(List<int> sizes, int count)
        {
            //TODO
            List<SortData> display = PerformancesTest(sizes, count);
            Console.WriteLine("Tableau :");
            for (int i = 0; i < sizes.Count; i++)
            {
                Console.Write($" Tableau {i} : Insertion : {display[i].InsertionMean} ms  Quick : {display[i].QuickMean} ms Insertion S : {display[i].InsertionStd} ms  Quick S : {display[i].QuickStd} ms");
                Console.WriteLine(" ");

                //Console.Writeline($"{sizes[i].ToString().PadLeft(7,' '))};{display[i].InsertionMean};{display[i].QuickMean};{display[i].InsertionStd};{display[i].QuickStd}");

            }

        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            //TODO
            List<SortData> perfstest = new List<SortData>();
            for (int i = 0; i < sizes.Count; i++)
            {
                perfstest.Add(PerformanceTest(sizes[i], count));
            }

            return perfstest;
        }

        public static SortData PerformanceTest(int size, int count)
        {
            //TODO

            //int moyenne;

            //int m = count;

            //long insertionm = 0;
            //long quickm = 0;

            long[] insertions = new long[count];
            long[] quicks = new long[count];

            for (int i = 0; i < count; i++)
            {
                List<int[]> tabaleas = new List<int[]>();

                tabaleas = ArraysGenerator(size);

                //insertionm += UseInsertionSort(tabaleas[0]);
                //quickm += UseQuickSort(tabaleas[1]);

                insertions[i] = UseInsertionSort(tabaleas[0]);
                quicks[i] = UseQuickSort(tabaleas[1]);
            }

            //insertionm = insertionm / count;
            //quickm = quickm / count;

            //insertions = insertions / count;
            //quicks = quicks / count;

            SortData perftest = new SortData();
            perftest.InsertionMean = (long)insertions.Average();
            perftest.QuickMean = (long)quicks.Average();

            //perftest.InsertionStd = Math.Sqrt((insertions / count) - (insertions * insertions));
            //perftest.QuickStd = Math.Sqrt((quicks / count) - (quicks * quicks));


            perftest.InsertionStd = EcartType(insertions);
            perftest.QuickStd = EcartType(quicks);


            return perftest;

        }

        private static long EcartType(long[] tab)
        {
            long res = 0;
            if (tab.Length > 0)
            {
                long avg = (long)tab.Average();
                long sum = (long)tab.Sum(d => Math.Pow(d - avg, 2));

                //long sum = (long)tab.Sum(d => Math.Pow(d - avg, 2));
                res = (long)Math.Sqrt(sum / tab.Length);
            }
            return res;
        }


        private static List<int[]> ArraysGenerator(int size)
        {
            //TODO
            Random alea = new Random();

            List<int[]> tabaleas = new List<int[]>();

            int[] tabalea = new int[size];

            for (int i = 0; i < tabalea.Length; i++)
            {
                tabalea[i] = alea.Next(-1000, 1001);
            }

            tabaleas.Add(tabalea);
            tabaleas.Add(tabalea);

            return tabaleas;
        }

        public static long UseInsertionSort(int[] array)
        {
            //TODO

            Stopwatch watch = Stopwatch.StartNew();
            InsertionSort(array);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long UseQuickSort(int[] array)
        {
            //TODO
            Stopwatch watch = Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            };
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            int tmp = array[i];
            array[i] = array[right];
            array[right] = tmp;
            return i;
        }
    }
}
