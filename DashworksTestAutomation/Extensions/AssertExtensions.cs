using System;
using NUnit.Framework;

namespace DashworksTestAutomation.Extensions
{
    public static class AssertExtensions
    {
        public static void Equal(string exepected, string actual, string userFriendlyErrorMessage)
        {
            try
            {
                Assert.Equals(exepected, actual);
            }
            catch (Exception e)
            {
                throw new Exception(userFriendlyErrorMessage, e);
            }
        }
    }
}