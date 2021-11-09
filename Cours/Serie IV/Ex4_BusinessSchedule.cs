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
            _debut = new DateTime(2020, 1, 1);
            _fin = new DateTime(2030, 12, 31);
        }

        public bool IsEmpty()
        {

            if (_schedule.Count == 0)
            {
                return true;
            }

            return false;

            //return _schedule_Count == 0;
        }

        public void SetRangeOfDates(DateTime begin, DateTime end)
        {
            //si emploi du temps est vide, on peut modifier, sinon renvoi d'une exception
            if (!IsEmpty())
            {
                throw new Exception("L'emploi du temps n'est pas vide.");
            }
            //TODO: Si dates invalides (= null ou debut > fin)
            if (begin == null || end == null || begin >= end)
            {
                throw new ArgumentException("La date de début est supérieure à la date de fin.");
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
            DateTime datemin = DateTime.MinValue;
            DateTime datemax = DateTime.MaxValue;

            foreach (var meeting in _schedule)
            {
                if (meeting.Key <= beginMeeting && beginMeeting - meeting.Key < beginMeeting - datemin)
                {
                    datemin = meeting.Key;
                }
                else if (meeting.Value > beginMeeting)
                {
                    datemax = meeting.Value;
                    break;
                }
            }
            return new KeyValuePair<DateTime, DateTime>(datemin, datemax);
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //TODO
            KeyValuePair<DateTime, DateTime> ajout = ClosestElements(date);
            if ((ajout.Key == DateTime.MinValue || _schedule[ajout.Key] <= date) && (ajout.Value == DateTime.MaxValue || ajout.Value >= date + duration))
            {
                _schedule.Add(date, date + duration);
                //Console.WriteLine("La réunion a bien été ajoutée à votre agenda.");
                return true;
            }
            //Console.WriteLine("La réunion n'a pu être ajoutée à votre agenda.");
            return false;
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //TODO
            KeyValuePair<DateTime, DateTime> supp = ClosestElements(date);

            if (!IsEmpty() && _schedule.ContainsKey(date) && _schedule[date] == duration)
            {

                return _schedule.Remove(date);
            }
            return false;
        }

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            //TODO

            int meetingsDeleted = 0;

            foreach (var meeting in _schedule.Keys)
            {
                if (meeting > begin && meeting < end)
                {
                    _schedule.Remove(meeting);
                    meetingsDeleted++;
                }
            }


            return meetingsDeleted;
        }

        public void DisplayMeetings()
        {
            Console.WriteLine($"Emploi du Temps : {_debut} - {_fin}");
            Console.WriteLine("-----------------------------------------------------------");
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

            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}