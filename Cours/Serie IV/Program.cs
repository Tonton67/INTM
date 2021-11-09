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
            //Exo 4
            BusinessSchedule bS = new BusinessSchedule();
            try
            {
                bS.SetRangeOfDates(DateTime.Today, DateTime.Now);
                //bS.SetRangeOfDates(DateTime.Now, DateTime.Today);
                bS.DisplayMeetings();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            };

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}