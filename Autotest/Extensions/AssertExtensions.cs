using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Autotest.Extensions
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
