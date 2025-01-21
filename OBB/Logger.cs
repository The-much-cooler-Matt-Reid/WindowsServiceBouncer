using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBB
{
    public class Logger
    {
        public static void WriteLog(string message)
        { if (!EventLog.SourceExists("OBBLogs"))
            {
                EventLog.CreateEventSource("OBBLogs", "Application");
            }
            EventLog.WriteEntry("OBBLogs", message, EventLogEntryType.Information);
        }
    }
}
