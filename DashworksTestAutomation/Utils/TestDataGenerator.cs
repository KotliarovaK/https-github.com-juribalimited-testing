using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Utils
{
    public static class TestDataGenerator
    {
        public static string RandomString(int length = 6)
        {
            if (length > 32)
                length = 32;

            return Guid.NewGuid().ToString("N").Substring(0, length);
        }

        public static string RandomEmail()
        {
            return $"At_{RandomString()}@attest.com";
        }
    }
}