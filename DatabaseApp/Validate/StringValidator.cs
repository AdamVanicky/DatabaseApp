using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseApp.Validators;

namespace DatabaseApp.Validate
{
    public class StringValidator:IStringValidator
    {
        public bool IsValid(string s)
        {
            return (!string.IsNullOrEmpty(s) && s.Length > 1);
        }
    }
}
