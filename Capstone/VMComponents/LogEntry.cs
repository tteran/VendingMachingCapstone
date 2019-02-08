using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VMComponents
{
    /// <summary>
    /// Represents a Log Entry
    /// </summary>
    public class LogEntry
    {
        /// <summary>
        /// The date and time
        /// </summary>
        readonly string dateTime = DateTime.Now.ToLocalTime().ToString();


        /// <summary>
        /// Logs the action
        /// </summary>
        string Action { get; }



    }
}
