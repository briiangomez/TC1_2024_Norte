using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain
{
    public class Log
    {
        public Log(DateTime date, string message, TraceLevel level = TraceLevel.Info)
        {
            Date = date;
            Message = message;
            Level = level;
        }

        public DateTime Date { get; set; }

        public string Message { get; set; }

        public TraceLevel Level { get; set; }

        ///Agregan toda la info que necesitan para su bitacora...
    }
}
