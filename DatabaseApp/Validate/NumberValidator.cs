using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseApp.Validators;

namespace DatabaseApp.Validate
{
    class NumberValidator:INumberValidator
    {
        public bool IsValid(string rc, DateTime dob)
        {
            DateTime dtCheck = new DateTime(1954, 1, 1);
            int value = DateTime.Compare(dob, dtCheck);
            string[] str = rc.Split('/');

            if (int.TryParse(str[0], out int i) == false || int.TryParse(str[1], out int j) == false) return false;

            if (value > 0 && str[1].Length == 4 || value <= 0 && str[1].Length == 3) return true;

            return false;
        }
    }
}
