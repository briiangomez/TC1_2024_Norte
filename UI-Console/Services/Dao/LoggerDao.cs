using Services.Dao.Contracts;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dao
{
    internal static class LoggerDao 
    {
        public static string PathLogError { get; set; } = ConfigurationManager.AppSettings["PathLogError"].ToString();

        public static string PathLogInfo { get; set; } = ConfigurationManager.AppSettings["PathInfoError"].ToString();

        public static void WriteLog(Log log, Exception ex = null)
        {
            string message = FormatMessage(log);

            switch (log.Level)
            {
                case TraceLevel.Error:
                    message += ex.StackTrace;

                    WriteLogToFile(PathLogError, message);

                    break;
                case TraceLevel.Warning:
                    break;
                case TraceLevel.Info:

                    message = FormatMessage(log);
                    WriteLogToFile(PathLogInfo, message);
                    break;
                default:
                    break;
            }
        }

        public static string FormatMessage(Log log)
        {
            return $"{log.Date.ToString("dd/MM/yyyy HH:mm:ss")} - {log.Level}: {log.Message} - ";
        }

        public static void WriteLogToFile(string path, string message)
        {
            //Aplica una politica de corte de logs
            path = DateTime.Now.ToString("dd-MM-yyyy") + path;

            using (StreamWriter str = new StreamWriter(path,true))
            {
                str.WriteLine(message);
            }
        }
    }
}
