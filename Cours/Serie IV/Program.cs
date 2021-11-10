using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exo 1
            Console.WriteLine("Exercice 1 : Code MORSE");
            Morse m = new Morse();
            Console.WriteLine("Traduction Morse :");




            //Code en Morse
            string morse = "===.=.===.=...===.===.===...===.=.=...=.....===.===...===.===.===...=.===.=...=.=.=...=";
            Console.WriteLine($"Compteur de lettres : {m.LettersCount(morse)}");
            Console.WriteLine($"Compteur de mots    : {m.WordsCount(morse)}");
            Console.WriteLine($"MT {morse} : {m.MorseTranslation(morse)}");
            morse = "===..=.===.=...===.===.===...===.=.=...=.....===.===...===.===.===...=.===.=...=.=.=...=";
            Console.WriteLine(m.EfficientMorseTranslation(morse));





            /*
            int numbers = 0123465789;
            string[] names = new string[] { "aaron", "abby", "abdul", "abe", "abel", "abiga" };

            PhoneBook pb = new PhoneBook();
            pb.AddPhoneNumber("0632359698", "Arthur");

            for (int i = 0; i < names.Length; i++)
            {
                pb.AddPhoneNumber("0" + numbers.ToString(), names[i]);
                numbers++;
            }
            pb.PhoneContact("0123456789");
            pb.DeletePhoneNumber("0123456789");
            pb.DisplayPhoneBook();
            /**/


            ////Exo 4
            //BusinessSchedule bS = new BusinessSchedule();
            //DateTime dt = DateTime.Today;
            //try
            //{
            //    bS.SetRangeOfDates(DateTime.Today, DateTime.Now);
            //    bS.SetRangeOfDates(new DateTime(2021, 1, 1), new DateTime(2021, 12, 31));

            //    //bS.SetRangeOfDates(DateTime.Now, DateTime.Today);
            //    TimeSpan oneHour = new TimeSpan(1, 0, 0);
            //    for (int i = 0; i < 24; i++)
            //    {
            //        bS.AddBusinessMeeting(dt, oneHour);
            //        dt += oneHour;
            //    }
            //    bS.DeleteBusinessMeeting(DateTime.Today + new TimeSpan(DateTime.Now.Hour, 0, 0), oneHour);
            //    bS.AddBusinessMeeting(DateTime.Now, oneHour);

            //    bS.DisplayMeetings();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //};


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}