﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.Validators
{
    public interface INumberValidator
    {
        bool IsValid(string s, DateTime date);
    }
}
