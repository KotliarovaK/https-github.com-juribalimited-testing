using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriverTests.ComponentHelper;
using SeleniumWebdriverTests.Settings;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumWebdriverTests.StepDefinitions
{
    [Binding]
    public sealed class EvergreenJnr_QueryStrings
    {
        public string url;
        public string combinedURL;

        #region When

        [When(@"Evergreen QueryStringURL is entered for Simple QueryType")]
        public void WhenEvergreenQueryStringURLIsEnteredForSimpleQueryType(Table table)
        {
           
            foreach (var row in table.Rows)
            {
                combinedURL = url + row["QueryStringURL"];
                NavigationHelper.NagigateToURL(combinedURL);
                Thread.Sleep(4000);
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

                if (GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")))
                {
                    GenericHelper.TakeScreenShot();
                    Console.WriteLine("500 error was returned for: {0}", row["QueryType"] + " query");
                    Assert.IsFalse(GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")));
                    break;
                }

                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[@class='rowCount']")));
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")));
                Console.WriteLine("Evergreen agGrid Main Object List is returned with data for: {0}", row["QueryType"] + " query");
                GenericHelper.TakeScreenShot();
            }
        }

        [When(@"Evergreen QueryStringURL is entered for Complex QueryType")]
        public void WhenEvergreenQueryStringURLIsEnteredForComplexQueryType(Table table)
        {
            foreach (var row in table.Rows)
            {
                combinedURL = url + row["QueryStringURL"];
                NavigationHelper.NagigateToURL(combinedURL);
                Thread.Sleep(6000);
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                if (GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")))
                {
                    GenericHelper.TakeScreenShot();
                    Console.WriteLine("500 error was returned for: {0}", row["QueryType"] + " query");
                    Assert.IsFalse(GenericHelper.IsElementPresent(By.XPath("//div[@class='status-code']")));
                    break;
                }
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[@class='rowCount']")));
                Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")));
                Console.WriteLine("Evergreen agGrid Main Object List is returned with data for: {0}", row["QueryType"] + " query");
                GenericHelper.TakeScreenShot();
            }
        }

        #endregion When
    }
}