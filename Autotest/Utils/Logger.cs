using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Autotest.Utils
{
    public static class Logger
    {
        public static void Write(string text)
        {
            TestContext.WriteLine(text);
        }

        public static void Write(Exception exception)
        {
            Write(exception.ToString());
        }

        public static void Write(string format, params object[] arg)
        {
            TestContext.WriteLine(format, arg);
        }
    }
}
