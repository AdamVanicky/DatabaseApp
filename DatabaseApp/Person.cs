using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string RodneCislo { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstname, string surname, string rodnecislo, DateTime dateofbirth)
        {
            FirstName = firstname;
            SurName = surname;
            RodneCislo = rodnecislo;
            DateOfBirth = dateofbirth;
        }
    }
}
