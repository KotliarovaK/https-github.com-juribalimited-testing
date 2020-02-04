using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Utils
{
    public class LoggingExtensions
    {
        static ReaderWriterLock locker = new ReaderWriterLock();

        public static void WriteDebug(string text)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", ""), "debug.txt");
                System.IO.File.AppendAllLines(path, new[] { text });
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }
    }
}
