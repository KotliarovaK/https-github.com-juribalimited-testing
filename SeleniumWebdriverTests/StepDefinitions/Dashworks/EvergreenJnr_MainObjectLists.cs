using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriverTests.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumWebdriverTests.StepDefinitions.Dashworks
{
    [Binding]
    public sealed class EvergreenJnr_MainObjectLists
    {
        #region Then

        [Then(@"agGrid Main Object List is returned with data")]
        public void ThenAgGridMainObjectListIsReturnedWithData()
        {
            //Checking that the number of rows element is visible
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[@class='rowCount']")));
            //Checking that the agGrid body element is visible
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//div[@class='ag-body-container']")));
            Console.WriteLine("Main agGrid dataset is displayed");
        }

        #endregion Then
    }
}
