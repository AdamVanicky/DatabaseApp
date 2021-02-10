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
            DateOfBirth = dtbirth;
            bool nameOK = false, surnameOK = false, rodnecisloOK = false;

            if (nameOK = stringValidator.IsValid(firstname)) FirstName = firstname;
            if (surnameOK = stringValidator.IsValid(surname)) SurName = surname;
            if (rodnecisloOK = numberValidator.IsValid(rodnecislo, dtbirth)) RodneCislo = rodnecislo;

            return (nameOK && surnameOK && rodnecisloOK);
        }
    }
}
