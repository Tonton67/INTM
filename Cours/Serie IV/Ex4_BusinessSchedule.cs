using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class BusinessSchedule
    {
        private SortedDictionary<DateTime, DateTime> _schedule;
        private DateTime _debut;
        private DateTime _fin;

        public BusinessSchedule()
        {
            _schedule = new SortedDictionary<DateTime, DateTime>();
            _debut = new DateTime(2021, 1, 1);
            _fin = new DateTime(2021, 12, 31);
        }

        public bool IsEmpty()
        {

            if (_schedule.Count == 0)
            {
                return true;
            }

            return false;
        }

        public void SetRangeOfDates(DateTime begin, DateTime end)
        {
            //si emploi du temps est vide, on peut modifier, sinon renvoi d'une exception
            if (!IsEmpty())
            {
                throw new Exception("Titi");
            }
            //TODO: Si dates invalides (= null ou debut > fin)
            if (begin == null || end == null || begin >= end)
            {
                throw new ArgumentException("Toto");
            }

            _debut = begin;
            _fin = end;

            /*
            if (!IsEmpty() || _reunion <= _debut || _reunion >= _fin)
            {
                try
                {
                    Console.WriteLine("La réunion n'est pas valide");
                }
                catch (Exception)
                {
                    Console.WriteLine("L'agenda n'est pas vide");

                    throw new Exception();
                }
            }
            */

        }

        private KeyValuePair<DateTime, DateTime> ClosestElements(DateTime beginMeeting)
        {
            //TODO
            DateTime _datemin = DateTime.MinValue;
            DateTime _datemax = DateTime.MaxValue;
            DateTime _date;

            foreach (var meeting in _schedule)
            {

            }


            return new KeyValuePair<DateTime, DateTime>();
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //TODO
            return false;
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //TODO
            return false;
        }

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            //TODO
            return -1;
        }

        public void DisplayMeetings()
        {
            Console.WriteLine($"Emploi du Temps : {_debut} - {_fin}");
            Console.WriteLine("-----------------------------------");
            int nbre = 1;
            if (IsEmpty())
            {
                Console.WriteLine("Pas de réunions programmées.");
            }
            else
            {
                foreach (var meeting in _schedule)
                {

                    Console.WriteLine($"Réunion {nbre} : {meeting.Key} - {meeting.Value}");
                    nbre++;
                }
            }
        }
    }
}