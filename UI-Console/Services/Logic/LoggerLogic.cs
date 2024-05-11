using Services.Dao;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logic
{
    internal static class LoggerLogic
    {
        public static void WriteLog(Log log, Exception ex = null)
        {
            if(log.Level == TraceLevel.Off)
            {
                //Envio un mail al area de infra
            }

            LoggerDao.WriteLog(log, ex);
        }
    }
}
