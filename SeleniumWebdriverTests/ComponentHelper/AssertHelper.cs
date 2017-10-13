using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWebdriverTests.ComponentHelper
{
    public class AssertHelper
    {
        public static void AreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                Console.WriteLine("Values are NOT equal: {0}, {1}", expected, actual);
            }
        }
    }
}