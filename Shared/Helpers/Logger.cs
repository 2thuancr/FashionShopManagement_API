using System;
using System.IO;

namespace Shared.Helpers
{
    public class Logger
    {
        private static string logName = "Log_";
        private static string logExtendtion = ".log";

        public static void WriteLog(string content)
        {
            string logNameToWrite = logName + DateTime.Now.ToLongDateString() + logExtendtion;
            StreamWriter sw = new StreamWriter(logNameToWrite, true);
            sw.WriteLine(DateTime.Now + " ## " + content);
            sw.Close();
        }
    }
}