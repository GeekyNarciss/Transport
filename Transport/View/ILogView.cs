﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.View
{
    interface ILogView
    {
        void SetLogs(List<string> LogString);
    }
}
