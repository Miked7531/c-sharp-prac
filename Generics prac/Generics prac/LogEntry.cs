﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_prac
{
    public class LogEntry
    {
        public int ErrorCode { get; set; }

        public string Message { get; set; }

        public DateTime TimeOfEvent { get; set; } = DateTime.UtcNow;
    }
}
