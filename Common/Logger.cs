using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Logger
    {
        private Logger log;
        public Logger() { }
        ~Logger() { }

        public void LogInTxt(string message) {
            using (StreamWriter w = File.AppendText("../../../../log.txt"))
            {
                w.WriteLine(message);
            }
        }

        public void LogError(string error)
        {
            log.LogError(error);
        }

        public void LogInfo(string message) {
            log.LogInfo(message);
        }
    }
}
