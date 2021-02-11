using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseApp.Validators;
using System.Text.RegularExpressions;

namespace DatabaseApp.Validate
{
    public class NumberValidator:INumberValidator
    {
        public bool IsValid(string rc, DateTime dob)
        {
            Regex r = null;
            DateTime dtCheck = new DateTime(1954, 1, 1);
            int value = DateTime.Compare(dob, dtCheck);

            if (value > 0) r = new Regex("^[0-9]{6}/[0-9]{4}$");
            else if(value < 0) r = new Regex("^[0-9]{6}/[0-9]{3}$");

            if (!string.IsNullOrEmpty(rc) && r.IsMatch(rc)) return true;

            return false;
        }
    }
}
