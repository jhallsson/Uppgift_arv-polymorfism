﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text-only field. This fired an error!";
        }
    }
}
