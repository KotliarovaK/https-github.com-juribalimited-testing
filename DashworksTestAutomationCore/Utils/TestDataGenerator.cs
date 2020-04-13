using System;

namespace DashworksTestAutomation.Utils
{
    public static class TestDataGenerator
    {
        private static int _randomNumber;

        public static string RandomString(int length = 6)
        {
            var baseString = Guid.NewGuid().ToString("N");
            while (baseString.Length <= length)
            {
                baseString = Guid.NewGuid().ToString("N");
            }

            return baseString.Substring(0, length);
        }

        public static string RandomEmail()
        {
            return $"At_{RandomString()}@attest.com";
        }

        /// <summary>
        /// This method handle situation when same random numbers are generated instantly
        /// </summary>
        /// <param name="maxValue"></param>
        /// <param name="minValue"></param>
        /// <returns></returns>
        public static int RandomNum(int maxValue, int minValue = 0)
        {
            int randNum = new Random().Next(minValue, maxValue);
            int attempts = 5;
            while (randNum == _randomNumber && attempts > 0)
            {
                randNum = new Random().Next(maxValue);
                attempts--;

                if (randNum == _randomNumber)
                    System.Threading.Thread.Sleep(14);
            }
            _randomNumber = randNum;
            return randNum;
        }
    }
}