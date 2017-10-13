using System;

namespace SeleniumWebdriverTests.CustomException
{
    [Serializable]
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string msg) : base(msg)
        {
        }
    }
}