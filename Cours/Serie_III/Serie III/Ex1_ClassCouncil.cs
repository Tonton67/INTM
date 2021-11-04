using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public static class ClassCouncil
    {
        public static void SchoolMeans(string input, string output)
        {
            //TODO
            var matieres = new Dictionary<string, List<float>>();

            string[] lines = File.ReadAllLines(input);
            foreach (string line in lines)
            {
                Console.WriteLine($"Fichier : {line} ");
                string[] split = line.Split(';');
                for (int i = 0; i < split.Length; i++)
                {
                    Console.WriteLine(split[i]);
                }
                string matiere = split[1];
                float moyenne;
                bool convers = float.TryParse(split[2].Replace('.', ','), out moyenne);

                if (!matieres.ContainsKey(matiere))
                {
                    matieres.Add(matiere, new List<float>());
                }
                matieres[matiere].Add(moyenne);
            }
            // Calcul de moyenne par matière
            string[] results = new string[matieres.Count];
            int k = 0;
            foreach (var moyennes in matieres)
            {
                Console.WriteLine(moyennes.Key);
                Console.WriteLine(moyennes.Value.Average());
                results[k] = $"{moyennes.Key} : {moyennes.Value.Average()}";
                k++;
            }





            //// test 1
            //System.Nullable<float> averagemoyenne =
            //    (from matieres in db.matieres select matieres).Average();

            //// test 2
            //float moyennes = List<float>;
            //for (int i = 0; i < matieres.Count; i++)
            //{

            //    if (!matieres.ContainsValue(moyennes) == 0)
            //    {
            //        moyennes / matieres[i];
            //    }

            //}


            // Ecriture fichier de sortie
            File.WriteAllLines(output, results);
            //Console.WriteLine($"Sortie : {results}");
        }
    }
}
