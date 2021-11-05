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

            int numbers = 0123465789;
            string[] names = new string[] { "aaron", "abby", "abdul", "abe", "abel", "abiga" };

            PhoneBook pb = new PhoneBook();
            pb.AddPhoneNumber("0632359698", "Arthur");
            for (int i = 0; i < names.Length; i++)
            {
                pb.AddPhoneNumber

            }



            Console.WriteLine();

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
