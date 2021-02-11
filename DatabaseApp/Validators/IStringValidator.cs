using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.Validators
{
    public interface IStringValidator
    {
        bool IsValid(string s);
    }
}
