using System;
using System.IO;
using System.Text;

namespace Logger
{
    public sealed class Log : ILogger
    {
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        private static readonly object obj = new object();

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}-{1}.log", "Exception", DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
            string filepath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }

        }
    }
}
