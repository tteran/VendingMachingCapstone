using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.VMComponents
{
    public class Log
    {
        private readonly List<LogEntry> logList = new List<LogEntry>();

        public Log()
        {
            
        }

        //public Log(LogEntry logEntry)
        //{
        //    logList.Add(logEntry);
        //}
        public void AddLogEntry(LogEntry logEntry)
        {
            logList.Add(logEntry);
        }

        /// <summary>
        /// Appends audit log.
        /// </summary>
        public void WriteToLog()
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.WriteLine($"Transaction entries recorded at: {DateTime.Now.ToLocalTime()}");
                foreach(LogEntry entry in logList)
                {
                    string entryLine = entry.MakeLogEntry();
                    sw.WriteLine(entryLine);
                }
            }
            logList.Clear();
        }
    }
}
