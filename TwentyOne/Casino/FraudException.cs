﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class FraudException: Exception
    {
        public FraudException()
            : base() { }    // Inheriting from the base Exception
        public FraudException(string message)
            : base(message) { }
    }
}
