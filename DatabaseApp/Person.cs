using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseApp.Validators;

namespace DatabaseApp
{
    class Person
    {
        readonly IStringValidator stringValidator;
        readonly INumberValidator numberValidator;
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string RodneCislo { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(IStringValidator isv, INumberValidator inv)
        {
            stringValidator = isv;
            numberValidator = inv;
        }

        public bool Checkup(string firstname, string surname, string rodnecislo, DateTime dtbirth)
        {
            bool stringOK;
            bool intOk;

            do
            {
                if (string.IsNullOrEmpty(firstname)) return false;
                if (stringOK = stringValidator.IsValid(firstname))
                {
                    FirstName = firstname;
                }
            }
            while (stringOK == false);

            stringOK = false;

            do
            {
                if (string.IsNullOrEmpty(surname)) return false;
                if (stringOK = stringValidator.IsValid(surname))
                {
                    SurName = surname;
                }
            }
            while (stringOK == false);

            do
            {
                if (string.IsNullOrEmpty(rodnecislo)) return false;
                if (intOk = numberValidator.IsValid(rodnecislo, dtbirth))
                {
                    RodneCislo = rodnecislo;
                }
            }
            while (intOk == false);

            return true;
        }
    }
}
