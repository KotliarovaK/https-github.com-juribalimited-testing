using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumWebdriverTests.StepDefinitions.Dashworks
{
    [Binding]
    public sealed class EvergreenJnr_ListMenu
    {
        [Then(@"Save to New Custom List element should NOT be displayed")]
        public void ThenSaveToNewCustomListElementShouldNOTBeDisplayed()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            Assert.IsFalse(GenericHelper.IsElementPresent(By.XPath("//span[.='Save']")));
            Console.WriteLine("The Save to Custom List Element was NOT displayed");
        }
    }
}
