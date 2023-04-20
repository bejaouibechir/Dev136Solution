using System.Diagnostics;

namespace WebAppCoreNouvelle.Services
{
    public class LoggerService : ILoggerService
    {
        DateTime now;
        public void Trace(string message)
        {
            now = DateTime.Now;
            EventLog.WriteEntry("Application", message + $" {now}", EventLogEntryType.Information);
        }
    }
}
