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

            int[] res = Eratosthene.EratosthenesSieve(100);
            foreach (int nbr in res)
            {
                if (nbr != 0)
                {
                    Console.Write(nbr);
                    Console.Write(",");
                }
            }

            Console.WriteLine("Exercice 2");

            //Console.WriteLine(Matrix.BuildingMatrix(1,-1));

            Console.WriteLine("Exercice 4");

            //string question = "Quelle est l'année du sacre de Charlemagne";
            //string[] answers = new string[] { "476", "800", "1066", "1798" };
            //int solution = 1;
            //int weight = 1;
            //Qcm qcm1 = new Qcm(question, answers, solution, weight);
            //Qcm qcm2 = new Qcm();
            //qcm2.Question = question;
            //qcm2.Answers = answers;
            //Quiz.AskQuestion(qcm1);

            Qcm[] qcms = new Qcm[3]
            {
                new Qcm
                {
                    Question = "Quelle l'année du sacre de Charlemagne ?",
                    Answers = new string[] { "476", "800", "1066", "1789" },
                    Solution = 1,
                    Weight = 1
                },
                new Qcm
                {
                    Question = "Quelle l'année du sacre de Charlemagne ?",
                    Answers = new string[] { "476", "800", "1066", "1789" },
                    Solution = 1,
                    Weight = 3
                },
                new Qcm
                {
                    Question = "Quelle l'année du sacre de Charlemagne ?",
                    Answers = new string[] { "476", "800", "1066", "1789" },
                    Solution = 12,
                    Weight = -40
                }
            };
            Quiz.AskQuestions(qcms);

            int[] left = { 1, 2, 3 };
            int[] right = { -1, -4, 0 };

            int[][] matrix = Matrix.BuildingMatrix(left, right);
            Matrix.DisplayMatrix(matrix);

            int[][] left1 =
            {
                new int[]{ 1,2},
                new int[]{ 4,6},
                new int[]{ -1,8}
            };
            int[][] right1 =
                {
                new int[] {-1, 5 },
                new int[] {-4, 0 },
                new int[] { 0, 2 }
                };

            matrix = Matrix.Addition(left1, right1);
            Matrix.DisplayMatrix(matrix);
            matrix = Matrix.Substraction(left1, right1);
            Matrix.DisplayMatrix(matrix);

            int[][] left2 =
       {
                new int[]{ 1,2},
                new int[]{ 4,6},
                new int[]{ -1,8}
            };
            int[][] right2 =
                {
                new int[] {-1, 5, 0 },
                new int[] {-4, 0, 1 },
            };
            
            matrix = Matrix.Multiplication(left2, right2);
            Matrix.DisplayMatrix(matrix);



            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
