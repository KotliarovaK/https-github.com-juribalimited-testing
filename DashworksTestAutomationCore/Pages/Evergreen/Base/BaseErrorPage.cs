using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseErrorPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='status-code']/span")]
        public IWebElement StatusCode { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='error-message-box']/p")]
        public IWebElement Message { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }

        public void VerifyStatusCode(string statusCode)
        {
            Verify.AreEqual(statusCode, StatusCode.Text,
                "Incorrect status code");
        }

        public void VerifyErrorMessage(string message)
        {
            Verify.AreEqual(message, Message.Text,
                "Incorrect error message");
        }
    }
}
