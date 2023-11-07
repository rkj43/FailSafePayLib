using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSafePayLib
{
    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            // TODO 
            // This should catch all exceptions and not throw any errors that would affect the payment processing
        }
    }

    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }

}
