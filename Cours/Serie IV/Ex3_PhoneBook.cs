using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class PhoneBook
    {


        private Dictionary<string, string> _contacts;

        public PhoneBook()
        {
            _contacts = new Dictionary<string, string>();
        }


        private bool IsValidPhoneNumber(string phoneNumber)
        {
            //TODO

            if (phoneNumber.Length == 10 && phoneNumber[0] == '0' && phoneNumber[1] != '0')
            {
                for (int i = 1; i < phoneNumber.Length; i++)
                {
                    if (!char.IsDigit(phoneNumber[i]))
                    {
                        return false;
                    }

                }

                return true;
            }

            return false;
        }

        public bool ContainsPhoneContact(string phoneNumber)
        {
            //TODO

            return _contacts.ContainsKey(phoneNumber);


            //if (!_contacts.ContainsKey(phoneNumber))
            //{
            //    return false;
            //}

            //return true;
        }

        public void PhoneContact(string phoneNumber)
        {
            //TODO

            if (ContainsPhoneContact(phoneNumber))
            {
                Console.WriteLine($" Le numéro {phoneNumber} a été trouvé. Répertoire : {_contacts[phoneNumber]}");

            }
            else
            {
                throw new ArgumentException("Numéro non présent");
                //Console.WriteLine($" Damn ! Le numéro {_contacts.ContainsKey(phoneNumber)} n'a pas pu être trouvé.");

            }



        }

        public bool AddPhoneNumber(string phoneNumber, string name)
        {
            //TODO
            bool validadd = IsValidPhoneNumber(phoneNumber);
            if (validadd == true)
            {

                bool ajout = ContainsPhoneContact(phoneNumber);
                if (ajout == true)
                {
                    _contacts.Add(phoneNumber, name);
                    Console.WriteLine($"Le contact {phoneNumber} a bien été ajouté à votre répertoire.");
                    return true;
                }

            }
            Console.WriteLine($"My BAD ! Le contact {phoneNumber} n'a pas pu être ajouté à votre répertoire.");
            return false;
        }

        public bool DeletePhoneNumber(string phoneNumber)
        {
            //TODO
            if (_contacts.Remove(phoneNumber))
            {

                Console.WriteLine($"Le contact {phoneNumber} a bien été supprimé à votre répertoire.");
                return true;
            }

            Console.WriteLine($"My BAD ! Le contact {phoneNumber} n'a pas pu être supprimé à votre répertoire.");
            return false;
        }

        public void DisplayPhoneBook()
        {
            //TODO
            //Dictionary<string, string> display = _contacts;

            //for (int i = 0; i < _contacts.Count; i++)
            //{
            //    Console.WriteLine($" Répertoire {i}");
            //    Console.WriteLine($"Numéro de téléphone :  {display[i]._contact}.");
            //    Console.WriteLine("Fin du répertoire.");

            //}

            if (_contacts.Count == 0)
            {
                Console.WriteLine("Pas de numéros téléphoniques.");
            }
            else
            {
                foreach (var contact in _contacts)
                {
                    Console.WriteLine($"{contact.Key} : {contact.Value}");
                    Console.WriteLine();
                }

            }

        }
    }
}
