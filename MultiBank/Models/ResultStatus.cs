﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiBank.Models
{
    public enum ResultStatus
    {
        OK = 100,
        Failed = 101,
        NotLogin = 102,
        Unauthorized = 103,
    }
}