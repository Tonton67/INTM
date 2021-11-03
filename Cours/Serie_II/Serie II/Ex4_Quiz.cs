using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public struct Qcm
    {
        public string Question;
        public string[] Answers;
        public int Solution;
        public int Weight;

        public Qcm(string question, string[] answers, int solution, int weight)
        {
            Question = question;
            Answers = answers;
            Solution = solution;
            Weight = weight;
        }
    }

    public static class Quiz
    {
        public static void AskQuestions(Qcm[] qcms)
        {
            //TODO
            int note = 0;
            int total = 0;
            for (int i = 0; i < qcms.Length; i++)
            {
                if (QcmValidity(qcms[i]))
                {
                    note += AskQuestion(qcms[i]);
                    total += qcms[i].Weight;
                }

            }
            Console.WriteLine($"Note : {note} / {total}");
        }

        public static int AskQuestion(Qcm qcm)
        {
            //TODO
            Console.WriteLine(qcm.Question);

            for (int i = 0; i < qcm.Answers.Length; i++)
            {
                Console.Write(qcm.Answers[i]);
                Console.Write(" ");

            }
            Console.WriteLine(" ");
            Console.WriteLine("Saisir une réponse.");
            string answers = Console.ReadLine();
            int ent;
            int.TryParse(answers, out ent);
            while (!int.TryParse(answers, out ent) || (ent < 0 || ent >= qcm.Answers.Length))
            {
                Console.WriteLine("Merci de bien vouloir ressaisir une réponse.");
                answers = Console.ReadLine();
            }
            if (ent != qcm.Solution)
            {
                Console.WriteLine("Réponse invalide.");
            }
            else
            {
                Console.WriteLine("Réponse valide.");
                return qcm.Weight;
            }

            return 0;
        }

        public static bool QcmValidity(Qcm qcm)
        {
            if (qcm.Weight > 0 && 0 <= qcm.Solution && qcm.Solution < qcm.Answers.Length)
            {
                return true;
            }

            return false;
        }
    }
}
