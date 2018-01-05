using System;
using NUnit.Framework;

namespace DashworksTestAutomation.Utils
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